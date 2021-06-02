using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class ChangeTypeArea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BranchArea",
                table: "Branches");

            migrationBuilder.AddColumn<int>(
                name: "Area",
                table: "Branches",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Branches");

            migrationBuilder.AddColumn<string>(
                name: "BranchArea",
                table: "Branches",
                type: "text",
                nullable: true);
        }
    }
}
