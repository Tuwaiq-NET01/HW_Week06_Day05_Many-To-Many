using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_ef.Migrations
{
    public partial class addSeed_teachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Email", "FullName" },
                values: new object[] { 1, "0x1337@<(cat domain).wat", "D7000M Sensei" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
