using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class SeedingToNewBranchTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aria",
                table: "Branches");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Branches",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Branches");

            migrationBuilder.AddColumn<string>(
                name: "Aria",
                table: "Branches",
                type: "text",
                nullable: true);
        }
    }
}
