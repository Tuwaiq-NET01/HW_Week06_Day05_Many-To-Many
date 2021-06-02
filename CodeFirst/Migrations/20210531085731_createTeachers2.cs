using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class createTeachers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FulltName",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "FulltName",
                table: "Teachers",
                type: "text",
                nullable: true);
        }
    }
}
