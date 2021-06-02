using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace CodeFirstApp.Migrations
{
    public partial class ManyToManyRelationshipJoinedClassv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomersProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    CustomersId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    ProductsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersProducts_Customers1_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersProducts_Products1_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomersProducts_CustomersId",
                table: "CustomersProducts",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersProducts_ProductsId",
                table: "CustomersProducts",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersProducts");

            migrationBuilder.DropTable(
                name: "Customers1");

            migrationBuilder.DropTable(
                name: "Products1");
        }
    }
}
