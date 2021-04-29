using Microsoft.EntityFrameworkCore.Migrations;

namespace Duello.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Budgets",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Budgets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Budgets",
                table: "Budgets",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Budgets",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Budgets");

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    JumlahUang = table.Column<double>(type: "float", nullable: false),
                    NamaBudget = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    JumlahUang = table.Column<double>(type: "float", nullable: false),
                    NamaBudget = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }
    }
}
