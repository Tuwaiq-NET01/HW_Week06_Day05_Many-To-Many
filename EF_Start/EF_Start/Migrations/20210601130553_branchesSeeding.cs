using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Start.Migrations
{
    public partial class branchesSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branchs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "Id", "Address", "Area", "Name" },
                values: new object[] { 1, "riyadh", "Alnakul", "Branch01" });

            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "Id", "Address", "Area", "Name" },
                values: new object[] { 2, "riyadh", "Alnakul", "Branch02" });

            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "Id", "Address", "Area", "Name" },
                values: new object[] { 3, "riyadh", "Alnakul", "Branch03" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branchs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
