using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class RelationsBetweenStdAndRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_StudentId",
                table: "Rooms",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Students_StudentId",
                table: "Rooms",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Students_StudentId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_StudentId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Rooms");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "moh@example.com", "Mohammed", "Rashed" },
                    { 2, "Saad@example.com", "Saad", "Khalid" },
                    { 3, "Abdul@example.com", "Abdullah", "Ahmed" },
                    { 4, "test@example.com", "Khalid", "Abdulaziz" }
                });
        }
    }
}
