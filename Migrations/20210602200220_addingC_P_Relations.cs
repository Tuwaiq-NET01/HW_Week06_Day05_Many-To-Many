using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class addingC_P_Relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerProducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "CustomerProducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProducts_CustomerId",
                table: "CustomerProducts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProducts_ProductId",
                table: "CustomerProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProducts_Customers_CustomerId",
                table: "CustomerProducts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProducts_Products_ProductId",
                table: "CustomerProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProducts_Customers_CustomerId",
                table: "CustomerProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProducts_Products_ProductId",
                table: "CustomerProducts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerProducts_CustomerId",
                table: "CustomerProducts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerProducts_ProductId",
                table: "CustomerProducts");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerProducts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CustomerProducts");
        }
    }
}
