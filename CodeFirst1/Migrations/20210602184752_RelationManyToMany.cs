using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace CodeFirst1.Migrations
{
    public partial class RelationManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "subject");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "subject",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Teacher_Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacher_Student_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teacher_Student_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Student_StudentId",
                table: "Teacher_Student",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Student_TeacherId",
                table: "Teacher_Student",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_subject_Teachers_TeacherId",
                table: "subject",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subject_Teachers_TeacherId",
                table: "subject");

            migrationBuilder.DropTable(
                name: "Teacher_Student");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "subject",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "subject",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_subject_SubjectId",
                table: "subject",
                column: "SubjectId");

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
    }
}
