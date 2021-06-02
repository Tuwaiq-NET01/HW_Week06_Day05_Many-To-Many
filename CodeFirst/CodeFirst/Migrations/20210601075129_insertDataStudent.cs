using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class insertDataStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "email", "firstName", "lastName" },
                values: new object[,]
                {
                    { 1, "BQ@gmail.com", "Albandry", "AlQaseemi" },
                    { 2, "SQ@gmail.com", "Sarah", "AlQaseemi" },
                    { 3, "sami@gmail.com", "Sami", "Aldahlawi" },
                    { 4, "waleed@gmail.com", "Waleed", "AlQaseemi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
