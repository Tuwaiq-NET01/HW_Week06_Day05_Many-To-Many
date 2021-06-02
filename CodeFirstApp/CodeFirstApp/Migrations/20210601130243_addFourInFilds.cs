using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class addFourInFilds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "Id", "Adress", "Area", "Name" },
                values: new object[,]
                {
                    { 1, "Riyadh", "Laban", "Branch01" },
                    { 2, "Riyadh", "Laban", "Branch02" },
                    { 3, "Riyadh", "Laban", "Branch03" },
                    { 4, "Riyadh", "Laban", "Branch04" },
                    { 5, "Riyadh", "Laban", "Branch05" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
