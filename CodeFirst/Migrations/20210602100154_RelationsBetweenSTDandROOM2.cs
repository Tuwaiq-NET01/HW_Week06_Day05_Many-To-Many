using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class RelationsBetweenSTDandROOM2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rooms_StudentId",
                table: "Rooms");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_StudentId",
                table: "Rooms",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rooms_StudentId",
                table: "Rooms");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_StudentId",
                table: "Rooms",
                column: "StudentId");
        }
    }
}
