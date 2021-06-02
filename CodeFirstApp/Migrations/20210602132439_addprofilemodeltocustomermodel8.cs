using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class addprofilemodeltocustomermodel8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ProfileId",
                table: "Customers",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Products_ProfileId",
                table: "Customers",
                column: "ProfileId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Products_ProfileId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ProfileId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Customers");
        }
    }
}
