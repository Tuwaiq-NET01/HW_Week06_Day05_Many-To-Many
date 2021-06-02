using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst1.Migrations
{
    public partial class Teachrt_studentRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentsId",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentsId",
                table: "Students",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_StudentsId",
                table: "Students",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_StudentsId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentsId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentsId",
                table: "Students");
        }
    }
}
