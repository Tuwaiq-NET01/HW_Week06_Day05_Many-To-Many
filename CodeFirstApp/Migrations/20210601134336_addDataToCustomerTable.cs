using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class addDataToCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "AbdulrahmanJ@gmail.com", "Abdulrahman", "Aljfar" },
                    { 2, "AbdulrahmanJ@gmail.com", "Abdulrahman", "Aljfar" },
                    { 3, "AbdulrahmanJ@gmail.com", "Abdulrahman", "Aljfar" },
                    { 4, "AbdulrahmanJ@gmail.com", "Abdulrahman", "Aljfar" },
                    { 5, "AbdulrahmanJ@gmail.com", "Abdulrahman", "Aljfar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
