
using atendecidadao.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using atendecidadao.Filters;
using atendecidadao.Repositories;
using atendecidadao.Services;

namespace atendecidadao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var services = builder.Services;

            // CONFIGURACAO DO BANCO DE DADOS
            services.AddDbContext<ApiDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // CONFIGURACAO DO ESQUEMA DE AUTENTICACAO
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]))
                    };
                });

            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
                });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Autoriza��o JWT usando o esquema Bearer. \r\n\r\n Digite 'Bearer' [espa�o] e, em seguida, seu token na caixa de texto abaixo.\r\n\r\nExemplo: \"Bearer 12345abcdef\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                options.OperationFilter<AuthorizeCheckOperationFilter>();
            });

            // ADICIONA OS SERVICOS
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();
            builder.Logging.AddDebug();
            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            builder.Services.AddScoped<IUsuarioService, UsuarioService>();
            builder.Services.AddScoped<ISolicitacaoRepository, SolicitacaoRepository>();
            builder.Services.AddScoped<ISolicitacaoService, SolicitacaoService>();
            builder.Services.AddScoped<IAnexoRepository, AnexoRepository>();
            builder.Services.AddScoped<IAnexoService, AnexoService>();


            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            // EXECUTA OS MIGFRATIONS NO BANCO DE DADOS
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApiDbContext>();
                dbContext.Database.Migrate();
            }
            

            app.Run();
        }
    }
    
}
