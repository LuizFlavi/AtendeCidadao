using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace atendecidadao.Migrations
{
    /// <inheritdoc />
    public partial class m01AddTableSolicitacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solicitacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitacoes", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solicitacoes");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Senha",
                value: "$2a$11$OFGW0hUAQb0f8z7m8lp0P.5tPBoFfyc9QuKGjjGrQpZoJz9Wsls5G");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "Senha",
                value: "$2a$11$Zri1XNowhhTATUv1.fKvzO82u8HK/Z5uWFFhU9nyQsLFjb3NZWHpW");
        }
    }
}
