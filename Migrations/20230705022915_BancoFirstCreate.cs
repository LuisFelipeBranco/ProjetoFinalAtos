using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeplanConsultoria.Migrations
{
    public partial class BancoFirstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propriedade",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePropriedade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area = table.Column<double>(type: "float", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeProprietario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contato = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propriedade", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propriedade");
        }
    }
}
