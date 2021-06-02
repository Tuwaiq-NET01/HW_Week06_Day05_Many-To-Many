using Microsoft.EntityFrameworkCore.Migrations;

namespace EFIntro.Migrations
{
    public partial class AddAreaBranchesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
