using Microsoft.EntityFrameworkCore.Migrations;

namespace Duello.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    NamaBudget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumlahUang = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    NamaBudget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumlahUang = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    NamaBudget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumlahUang = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Incomes");
        }
    }
}
