using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp1.Migrations
{
    public partial class insertIntoCustomres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "sara@gmail", "sara" },
                    { 2, "amal@gmail", "amal" },
                    { 3, "battal@gmail", "battal" },
                    { 4, "fares@gmail", "fares" }
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
