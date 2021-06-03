using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_ef.Migrations
{
    public partial class addingRoomCol_student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "student_roomId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_student_roomId",
                table: "Students",
                column: "student_roomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Rooms_student_roomId",
                table: "Students",
                column: "student_roomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Rooms_student_roomId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_student_roomId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "student_roomId",
                table: "Students");
        }
    }
}
