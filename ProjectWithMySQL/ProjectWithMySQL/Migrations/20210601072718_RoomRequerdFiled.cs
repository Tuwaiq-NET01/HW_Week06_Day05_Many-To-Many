using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWithMySQL.Migrations
{
    public partial class RoomRequerdFiled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomType",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomType",
                table: "Rooms",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
