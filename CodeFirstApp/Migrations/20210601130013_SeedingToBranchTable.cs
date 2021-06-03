using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class SeedingToBranchTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "id", "Adress", "Area", "Name" },
                values: new object[,]
                {
                    { 1, "Riydh", "alnakuli", "Branche01" },
                    { 2, "Jeedah", "alnakuli", "Branche02" },
                    { 3, "makkah", "alnakuli", "Branche03" },
                    { 4, "madinah", "alnakuli", "Branche04" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
