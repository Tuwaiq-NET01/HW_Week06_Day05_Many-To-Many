using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class MakeRelationCustomersProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductModelId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ProductModelId",
                table: "Customers",
                column: "ProductModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Products_ProductModelId",
                table: "Customers",
                column: "ProductModelId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Products_ProductModelId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ProductModelId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ProductModelId",
                table: "Customers");
        }
    }
}
