using Microsoft.EntityFrameworkCore.Migrations;

namespace EFIntro.Migrations
{
    public partial class AddMoreDataToBranches2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Name" },
                values: new object[] { "Jeddah", "JED-55" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Area", "Name" },
                values: new object[,]
                {
                    { 5, "Riyadh", "idk", "RH-55" },
                    { 6, "Qassim", "idk", "QA-55" },
                    { 7, "Median", "idk", "MD-55" },
                    { 8, "Makkah", "idk", "MK-55" },
                    { 9, "Riyadh", "idk", "RH-55" },
                    { 10, "Yunbu", "idk", "YU-55" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Name" },
                values: new object[] { "Riyadh", "RH-55" });
        }
    }
}
