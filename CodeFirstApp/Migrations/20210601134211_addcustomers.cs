using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class addcustomers : Migration
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

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branches",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "email", "firstName", "lasName" },
                values: new object[] { 1, "branch1", "riydah", "dkdk" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "email", "firstName", "lasName" },
                values: new object[] { 2, "branch1", "hel", "dkdwewek" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "email", "firstName", "lasName" },
                values: new object[] { 3, "branch1", "ss", "wewedkdk" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branches",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Area", "Name" },
                values: new object[,]
                {
                    { 1, "riydah", "dkdk", "hekro" },
                    { 2, "riydah", "dkdk", "hekro" },
                    { 3, "riydah", "dkdk", "hekro" },
                    { 4, "riydah", "dkdk", "hekro" },
                    { 5, "riydah", "dkdk", "hekro" },
                    { 6, "riydah", "dkdk", "hekro" }
                });
        }
    }
}
