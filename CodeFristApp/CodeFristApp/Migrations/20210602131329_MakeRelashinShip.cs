using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFristApp.Migrations
{
    public partial class MakeRelashinShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CostomerId",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CostomerId",
                table: "Profiles",
                column: "CostomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Costomers_CostomerId",
                table: "Profiles",
                column: "CostomerId",
                principalTable: "Costomers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Costomers_CostomerId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_CostomerId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "CostomerId",
                table: "Profiles");
        }
    }
}
