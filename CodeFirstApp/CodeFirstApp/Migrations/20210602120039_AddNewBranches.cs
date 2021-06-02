using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class AddNewBranches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "id", "Address", "Area", "Name" },
                values: new object[,]
                {
                    { 3, "LA", 23, "Mutaz" },
                    { 4, "SF", 478, "Mansour" },
                    { 5, "LA", 23, "Mutaz" },
                    { 6, "SF", 478, "Mansour" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
