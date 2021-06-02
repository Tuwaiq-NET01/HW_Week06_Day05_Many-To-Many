using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class ChangeNameOfAddressNew1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Branchs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "Id", "Email", "Name", "address" },
                values: new object[,]
                {
                    { 1, "a@a.com", "Anas", "Riyadh" },
                    { 2, "b@b.com", "Saud", "Riyadh" },
                    { 3, "c@c.com", "Hassan", "Jeddah" },
                    { 4, "t@t.com", "AAJ", "Dammam" }
                });
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

            migrationBuilder.DeleteData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Branchs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
