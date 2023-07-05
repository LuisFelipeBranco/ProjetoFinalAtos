using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeplanConsultoria.Migrations
{
    public partial class PropriedadeSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "contato",
                table: "Propriedade",
                newName: "Contato");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Propriedade",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "Propriedade",
                newName: "Area");

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Propriedade",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dataNota",
                table: "Propriedade",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dataPagamento",
                table: "Propriedade",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dataServico",
                table: "Propriedade",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Propriedade");

            migrationBuilder.DropColumn(
                name: "dataNota",
                table: "Propriedade");

            migrationBuilder.DropColumn(
                name: "dataPagamento",
                table: "Propriedade");

            migrationBuilder.DropColumn(
                name: "dataServico",
                table: "Propriedade");

            migrationBuilder.RenameColumn(
                name: "Contato",
                table: "Propriedade",
                newName: "contato");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Propriedade",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Propriedade",
                newName: "area");
        }
    }
}
