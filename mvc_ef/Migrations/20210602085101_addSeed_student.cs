using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_ef.Migrations
{
    public partial class addSeed_student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Fname", "Lname", "student_roomId" },
                values: new object[] { 1, "aziz@aziz.aziz", "Abdulaziz", "Alasmari", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
