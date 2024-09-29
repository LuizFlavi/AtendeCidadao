using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace atendecidadao.Migrations
{
    /// <inheritdoc />
    public partial class m02AddStatusSolicitacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Solicitacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Solicitacoes");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Senha",
                value: "$2a$11$aVAdLgPOVFUnTBxx8vaiOeXBOmna2MR9bPmF5Z39Z4Y0PdT9CFkX6");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "Senha",
                value: "$2a$11$oHTbxz2dBkJepXayUbhT8.dO4KMvhhNBKlkiQZ2vjfmxBolWYkyfu");
        }
    }
}
