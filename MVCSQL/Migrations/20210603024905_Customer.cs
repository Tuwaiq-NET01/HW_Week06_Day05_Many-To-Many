using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace MVCSQL.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Nada@gmail.com", "Nada", "Majed" },
                    { 2, "Nawal@gmail.com", "Nawal", "Rami" },
                    { 3, "Arwa@gmail.com", "Arwa", "Hassan" },
                    { 4, "Lamia@gmail.com", "Lamia", "Naif" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

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
    }
}
