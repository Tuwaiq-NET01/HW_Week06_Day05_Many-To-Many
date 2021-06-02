using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_mysql_practice.Migrations
{
    public partial class AddAreaCol : Migration
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
