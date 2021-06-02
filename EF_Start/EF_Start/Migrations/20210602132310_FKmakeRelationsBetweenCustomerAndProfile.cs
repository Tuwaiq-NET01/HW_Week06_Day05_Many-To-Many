using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Start.Migrations
{
    public partial class FKmakeRelationsBetweenCustomerAndProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CustomerID",
                table: "Profiles",
                column: "CustomerID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Customers_CustomerID",
                table: "Profiles",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Customers_CustomerID",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_CustomerID",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Profiles");
        }
    }
}
