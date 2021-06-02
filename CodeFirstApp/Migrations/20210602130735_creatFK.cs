using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class creatFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customerID",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_customerID",
                table: "Profiles",
                column: "customerID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Customers_customerID",
                table: "Profiles",
                column: "customerID",
                principalTable: "Customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Customers_customerID",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_customerID",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "customerID",
                table: "Profiles");
        }
    }
}
