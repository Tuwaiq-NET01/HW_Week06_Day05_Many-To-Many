using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_ef.Migrations
{
    public partial class addSeeds_teachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FullName" },
                values: new object[] { "0x1337@<(cat domain).wat", "D7000M Sensei" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Email", "FullName" },
                values: new object[,]
                {
                    { 3, "0xl33t@<(cat domain).wat", "Manea Sensei" },
                    { 4, "0x1337@<(cat domain).wat", "D7000M Sensei" },
                    { 5, "0xl33t@<(cat domain).wat", "Manea Sensei" },
                    { 6, "0x1337@<(cat domain).wat", "D7000M Sensei" },
                    { 7, "0xl33t@<(cat domain).wat", "Manea Sensei" },
                    { 8, "0x1337@<(cat domain).wat", "D7000M Sensei" },
                    { 9, "0xl33t@<(cat domain).wat", "Manea Sensei" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FullName" },
                values: new object[] { "0xl33t@<(cat domain).wat", "Manea Sensei" });
        }
    }
}
