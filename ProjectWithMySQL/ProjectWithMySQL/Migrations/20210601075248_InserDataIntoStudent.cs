using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWithMySQL.Migrations
{
    public partial class InserDataIntoStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomType",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, "Ahmed" },
                    { 2, "Ahmed" },
                    { 3, "Ahmed" },
                    { 4, "Ahmed" },
                    { 5, "Ahmed" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "RoomType",
                table: "Rooms",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
