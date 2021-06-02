using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class relationshipStudentAndRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "studentId",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_studentId",
                table: "Rooms",
                column: "studentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Students_studentId",
                table: "Rooms",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Students_studentId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_studentId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "studentId",
                table: "Rooms");
        }
    }
}
