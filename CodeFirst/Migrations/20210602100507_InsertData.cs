using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Subject",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "Amal@gmail.com", "Amal", "Almutairi" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "Lama@gmail.com", "Lama", "Al" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { 3, "Nora@gmail.com", "Reema", "Al" });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_TeacherId",
                table: "Subject",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Teachers_TeacherId",
                table: "Subject",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Teachers_TeacherId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_TeacherId",
                table: "Subject");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Subject");
        }
    }
}
