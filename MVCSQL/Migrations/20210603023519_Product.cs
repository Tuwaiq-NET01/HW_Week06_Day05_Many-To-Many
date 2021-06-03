using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace MVCSQL.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(maxLength: 20, nullable: true),
                    Price = table.Column<float>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Name", "Price" },
                values: new object[] { 1, "Black", "iPhone 12", 3222.92f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Name", "Price" },
                values: new object[] { 2, "Red", "iPhone 11", 2499f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Name", "Price" },
                values: new object[] { 3, "Grey", "iPhone 11", 2499f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Area", "Name" },
                values: new object[,]
                {
                    { 1, "Riyadh", 1, "Br1" },
                    { 2, "Makkah", 12, "Br2" },
                    { 3, "Jeddah", 3, "Br3" },
                    { 4, "Dammam", 8, "Br4" }
                });
        }
    }
}
