using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class SeedingData2IntoStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Eamil", "FirstName", "LastName" },
                values: new object[] { 5, "samirah@gmail.com", "Samirah", "Alhosainy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Eamil", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "arwa@gmail.com", "Arwa", "Wan La" },
                    { 2, "reham@gmail.com", "Reham", "Alonaizy" },
                    { 3, "amal@gmail.com", "Amal", "Almutairy" },
                    { 4, "abulaziz@gmail.com", "Abdulaziz", "almohammady" }
                });
        }
    }
}
