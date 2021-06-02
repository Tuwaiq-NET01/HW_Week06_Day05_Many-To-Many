using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class AddRelationshipCustomerProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CustomerId",
                table: "Profiles",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Customers_CustomerId",
                table: "Profiles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Customers_CustomerId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_CustomerId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Profiles");
        }
    }
}
