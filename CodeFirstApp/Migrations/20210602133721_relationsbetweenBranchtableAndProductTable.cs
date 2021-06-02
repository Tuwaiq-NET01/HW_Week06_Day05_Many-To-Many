using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class relationsbetweenBranchtableAndProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Profiles_CustomerId",
                table: "Profiles");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CustomerId",
                table: "Profiles",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BranchId",
                table: "Products",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Branchs_BranchId",
                table: "Products",
                column: "BranchId",
                principalTable: "Branchs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Branchs_BranchId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_CustomerId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Products_BranchId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CustomerId",
                table: "Profiles",
                column: "CustomerId");
        }
    }
}
