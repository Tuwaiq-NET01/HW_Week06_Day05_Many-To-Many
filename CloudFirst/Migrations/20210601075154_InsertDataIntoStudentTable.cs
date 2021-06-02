using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudFirst.Migrations
{
    public partial class InsertDataIntoStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "ControlS@gmail.com", "Abdulrahman", "Sarawiq" },
                    { 2, "ControlS@gmail.com", "Mohamad", "Saraw1rqrfiq" },
                    { 3, "ControlS@gmail.com", "Ibra", "asdas" },
                    { 4, "ControlS@gmail.com", "3zz", "Sqweqq" },
                    { 5, "ControlS@gmail.com", "ewreqtgerg", "sdfagtruye" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
