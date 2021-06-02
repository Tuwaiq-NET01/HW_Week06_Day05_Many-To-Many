using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace School.Migrations
{
    public partial class CourseAndStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CourseName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.CourseId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_CourseId",
                table: "students",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_courses_CourseId",
                table: "students",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_courses_CourseId",
                table: "students");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropIndex(
                name: "IX_students_CourseId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "students");
        }
    }
}
