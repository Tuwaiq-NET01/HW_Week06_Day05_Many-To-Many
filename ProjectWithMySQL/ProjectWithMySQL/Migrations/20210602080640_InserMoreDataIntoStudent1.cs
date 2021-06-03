using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWithMySQL.Migrations
{
    public partial class InserMoreDataIntoStudent1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 1,
                column: "Name",
                value: "Anis");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Krame");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 3,
                column: "Name",
                value: "saud");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 4,
                column: "Name",
                value: "sam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Ghada");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 1,
                column: "Name",
                value: "Ahmed");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Ahmed");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 3,
                column: "Name",
                value: "Ahmed");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 4,
                column: "Name",
                value: "Ahmed");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "id",
                keyValue: 5,
                column: "Name",
                value: "Ahmed");
        }
    }
}
