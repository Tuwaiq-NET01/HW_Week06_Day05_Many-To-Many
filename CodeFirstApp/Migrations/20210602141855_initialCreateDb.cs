using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace CodeFirstApp.Migrations
{
    public partial class initialCreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Area = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descripton = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 25, nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    BranchID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Branches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Profiles_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "ID", "Area", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "Riyadh", "saud.alshammari@tuwaiq.edu.sa", "Saud" },
                    { 2, "Riyadh", "saud.alshammari@tuwaiq.edu.sa", "Saud" },
                    { 3, "Riyadh", "saud.alshammari@tuwaiq.edu.sa", "Saud" },
                    { 4, "Riyadh", "saud.alshammari@tuwaiq.edu.sa", "Saud" },
                    { 5, "Dammam", "saud.alshammari@tuwaiq.edu.sa", "Saud" },
                    { 6, "Dammam", "saud.alshammari@tuwaiq.edu.sa", "Saud" },
                    { 7, "Hafr-Albatin", "saud.alshammari@tuwaiq.edu.sa", "Saud" },
                    { 8, "Jeddah", "saud.alshammari@tuwaiq.edu.sa", "Saud" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "saud.alshammari@tuwaiq.edu.sa", "Fahad", "Anas" },
                    { 2, "saud.alshammari@tuwaiq.edu.sa", "Fahad", "Anas" },
                    { 3, "saud.alshammari@tuwaiq.edu.sa", "Fahad", "Anas" },
                    { 4, "saud.alshammari@tuwaiq.edu.sa", "Fahad", "Anas" },
                    { 5, "saud.alshammari@tuwaiq.edu.sa", "Fahad", "Anas" },
                    { 6, "saud.alshammari@tuwaiq.edu.sa", "Fahad", "Anas" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BranchID",
                table: "Products",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CustomerID",
                table: "Profiles",
                column: "CustomerID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
