using Microsoft.EntityFrameworkCore;
using atendecidadao.Models;


namespace atendecidadao.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Solicitacao> Solicitacoes { get; set; }

        public DbSet<Anexo> Anexos { get; set; }
    }
}