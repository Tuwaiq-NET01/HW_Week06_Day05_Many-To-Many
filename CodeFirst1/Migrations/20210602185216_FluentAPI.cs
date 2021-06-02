using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst1.Migrations
{
    public partial class FluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Student_Students_StudentId",
                table: "Teacher_Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Student_Teachers_TeacherId",
                table: "Teacher_Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher_Student",
                table: "Teacher_Student");

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

            migrationBuilder.RenameTable(
                name: "Teacher_Student",
                newName: "Teachers_Students");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_Student_TeacherId",
                table: "Teachers_Students",
                newName: "IX_Teachers_Students_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_Student_StudentId",
                table: "Teachers_Students",
                newName: "IX_Teachers_Students_StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers_Students",
                table: "Teachers_Students",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Students_Students_StudentId",
                table: "Teachers_Students",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Students_Teachers_TeacherId",
                table: "Teachers_Students",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Students_Students_StudentId",
                table: "Teachers_Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Students_Teachers_TeacherId",
                table: "Teachers_Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers_Students",
                table: "Teachers_Students");

            migrationBuilder.RenameTable(
                name: "Teachers_Students",
                newName: "Teacher_Student");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_Students_TeacherId",
                table: "Teacher_Student",
                newName: "IX_Teacher_Student_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_Students_StudentId",
                table: "Teacher_Student",
                newName: "IX_Teacher_Student_StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher_Student",
                table: "Teacher_Student",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "StudentId", "StudentsId" },
                values: new object[] { 1, "Fatma@hotmail.com", "Fatma", "Alqhtnay", 0, null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "StudentId", "StudentsId" },
                values: new object[] { 2, "Housh@hotmail.com", "Housh", "Alqhtnay", 0, null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "StudentId", "StudentsId" },
                values: new object[] { 3, "Abdulaziz@hotmail.com", "Abdulaziz", "Alqhtnay", 0, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Student_Students_StudentId",
                table: "Teacher_Student",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Student_Teachers_TeacherId",
                table: "Teacher_Student",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
