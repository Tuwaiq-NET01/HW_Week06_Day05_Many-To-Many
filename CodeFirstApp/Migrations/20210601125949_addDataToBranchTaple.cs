using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class addDataToBranchTaple : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "id", "Address", "Area", "Name" },
                values: new object[,]
                {
                    { 1, "Riyadh", "Alnakuli", "Branch01" },
                    { 2, "Riyadh", "Alnakuli", "Branch02" },
                    { 3, "Riyadh", "Alnakuli", "Branch03" },
                    { 4, "Riyadh", "Alnakuli", "Branch04" },
                    { 5, "Riyadh", "Alnakuli", "Branch05" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
