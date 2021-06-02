using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFristApp.Migrations
{
    public partial class addAreeaField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Branch",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Branch");
        }
    }
}
