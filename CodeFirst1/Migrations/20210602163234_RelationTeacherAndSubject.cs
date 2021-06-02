using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst1.Migrations
{
    public partial class RelationTeacherAndSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "subject",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "subject",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_subject_SubjectId",
                table: "subject",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_subject_TeacherId",
                table: "subject",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_subject_subject_SubjectId",
                table: "subject",
                column: "SubjectId",
                principalTable: "subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_subject_Teachers_TeacherId",
                table: "subject",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subject_subject_SubjectId",
                table: "subject");

            migrationBuilder.DropForeignKey(
                name: "FK_subject_Teachers_TeacherId",
                table: "subject");

            migrationBuilder.DropIndex(
                name: "IX_subject_SubjectId",
                table: "subject");

            migrationBuilder.DropIndex(
                name: "IX_subject_TeacherId",
                table: "subject");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "subject");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "subject");
        }
    }
}
