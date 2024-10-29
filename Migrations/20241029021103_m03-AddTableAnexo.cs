using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace atendecidadao.Migrations
{
    /// <inheritdoc />
    public partial class m03AddTableAnexo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anexos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexos", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Senha",
                value: "$2a$11$dDPvaM21iyfGW6taM9NnZuSOCao/Wg2YJkfCk5MGjwmvNnR.7/qnu");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "Senha",
                value: "$2a$11$A0AVLYZdYjIoh4ur5LuiPOEWO1ajLFR.mdgZGQ2Us4ly1uHVEVjkO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anexos");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Senha",
                value: "$2a$11$f3Bb21GLFgviyP/numeNDOgKc6zGz/vDpuMgpN3hNd8Dnyhcn8f6m");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "Senha",
                value: "$2a$11$MFX.uGnwAu0OuvKN8ZHOS.Hrkz8VBFziKb9jLYt9CBp8f8oeHtyBC");
        }
    }
}
