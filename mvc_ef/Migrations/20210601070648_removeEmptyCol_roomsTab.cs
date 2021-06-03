using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_ef.Migrations
{
    public partial class removeEmptyCol_roomsTab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Empty",
                table: "Rooms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Empty",
                table: "Rooms",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
