using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class seedingCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "Mutaz@yahoo.com", "Mutaz", "Alajlan" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "sab@yahoo.com", "Mns", "saab" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "Email", "FirstName", "LastName" },
                values: new object[] { 3, "Thamer@yahoo.com", "Thamer", "Mashni" });
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
        }
    }
}
