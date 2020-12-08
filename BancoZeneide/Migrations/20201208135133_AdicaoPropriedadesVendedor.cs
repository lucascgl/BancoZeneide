using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoZeneide.Migrations
{
    public partial class AdicaoPropriedadesVendedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Aniversário",
                table: "Vendedor",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Vendedor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Vendedor",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aniversário",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Vendedor");
        }
    }
}
