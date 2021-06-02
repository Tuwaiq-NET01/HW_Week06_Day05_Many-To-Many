using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class RenameProfileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileModel_Customers_CustomerId",
                table: "ProfileModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfileModel",
                table: "ProfileModel");

            migrationBuilder.RenameTable(
                name: "ProfileModel",
                newName: "Profiles");

            migrationBuilder.RenameIndex(
                name: "IX_ProfileModel_CustomerId",
                table: "Profiles",
                newName: "IX_Profiles_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "id");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "ProfileModel");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_CustomerId",
                table: "ProfileModel",
                newName: "IX_ProfileModel_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfileModel",
                table: "ProfileModel",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileModel_Customers_CustomerId",
                table: "ProfileModel",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
