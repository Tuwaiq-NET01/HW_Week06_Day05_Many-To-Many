using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace CodeFirst.Migrations
{
    public partial class AddManytoManyRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherID",
                table: "Subjects",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Students_Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Teachers_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Teachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Teachers_StudentId",
                table: "Students_Teachers",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Teachers_TeacherId",
                table: "Students_Teachers",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "Students_Teachers");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherID",
                table: "Subjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
