using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class InsertNewBranches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Area", "Name" },
                values: new object[] { 5, "Riyadh", 9, "Br5" });
        }
    }
}
