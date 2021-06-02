using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class EditBranchsDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Branchs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Branchs");
        }
    }
}
