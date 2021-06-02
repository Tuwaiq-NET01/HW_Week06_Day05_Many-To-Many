using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFristApp.Migrations
{
    public partial class insertdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "Addres", "Area", "Name" },
                values: new object[,]
                {
                    { 1, "Riyadh", "------", "branch01" },
                    { 2, "Jeddah", "------", "branch02" },
                    { 3, "Qassim", "------", "branch03" },
                    { 4, "Riyadh", "------", "branch04" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
