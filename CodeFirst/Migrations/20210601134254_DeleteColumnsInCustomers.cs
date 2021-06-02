using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class DeleteColumnsInCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Customers",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
