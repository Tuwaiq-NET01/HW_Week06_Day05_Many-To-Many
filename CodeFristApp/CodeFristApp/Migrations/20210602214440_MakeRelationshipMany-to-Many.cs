using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace CodeFristApp.Migrations
{
    public partial class MakeRelationshipManytoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CostomerProductModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CostomerId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostomerProductModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostomerProductModel_Costomers_CostomerId",
                        column: x => x.CostomerId,
                        principalTable: "Costomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CostomerProductModel_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CostomerProductModel_CostomerId",
                table: "CostomerProductModel",
                column: "CostomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CostomerProductModel_ProductId",
                table: "CostomerProductModel",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostomerProductModel");
        }
    }
}
