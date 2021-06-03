using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp1.Migrations
{
    public partial class relationBetCustomerProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Profile",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_CustomerId",
                table: "Profile",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Customers_CustomerId",
                table: "Profile",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Customers_CustomerId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_CustomerId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Profile");
        }
    }
}
