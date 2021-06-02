using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace School.Migrations
{
    public partial class StudentTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "studentTeachers",
                columns: table => new
                {
                    StudentTeacherId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentTeachers", x => x.StudentTeacherId);
                    table.ForeignKey(
                        name: "FK_studentTeachers_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentTeachers_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentTeachers_StudentId",
                table: "studentTeachers",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_studentTeachers_TeacherId",
                table: "studentTeachers",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentTeachers");
        }
    }
}
