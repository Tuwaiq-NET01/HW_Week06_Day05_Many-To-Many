using Microsoft.EntityFrameworkCore.Migrations;

namespace EFIntro.Migrations
{
    public partial class AddDataToCustomersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "efkdl@email.com", "ahmed", "okdlkio" },
                    { 2, "efkdl@email.com", "khalid", "dfsfds" },
                    { 3, "efkdl@email.com", "sara", "sadsa" },
                    { 4, "efkdl@email.com", "nora", "fwerf" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
