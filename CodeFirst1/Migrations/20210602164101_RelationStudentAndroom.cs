using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst1.Migrations
{
    public partial class RelationStudentAndroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "roomId",
                table: "Rooms",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Rooms_roomId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_roomId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "roomId",
                table: "Rooms");
        }
    }
}
