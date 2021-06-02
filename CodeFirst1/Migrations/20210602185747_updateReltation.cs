using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst1.Migrations
{
    public partial class updateReltation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Rooms_roomId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_StudentsId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentsId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_roomId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentsId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "roomId",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_StudentId",
                table: "Rooms",
                column: "StudentId",
                unique: true);

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

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentsId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "roomId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentsId",
                table: "Students",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_roomId",
                table: "Rooms",
                column: "roomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Rooms_roomId",
                table: "Rooms",
                column: "roomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_StudentsId",
                table: "Students",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
