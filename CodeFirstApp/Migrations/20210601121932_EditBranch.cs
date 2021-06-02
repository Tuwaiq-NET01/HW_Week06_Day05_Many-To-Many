using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class EditBranch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Branches");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Branches",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Branches");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Branches",
                type: "text",
                nullable: true);
        }
    }
}
