using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class NewSeedingToCustomerTable : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branches",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "Yasmin@hotmail.com", "Yasmin", "AlGhamdi" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "Lamya@hotmail.com", "Lamya", "AlGhamdi" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { 3, "Layan@hotmail.com", "Layan", "AlGhamdi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
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
                    { 1, "Riyadh", "Alnakuli", "branch01" },
                    { 2, "Jeddah", "Huwilat", "branch02" },
                    { 3, "Jubail", "AlFanateer", "branch03" },
                    { 4, "Dammam", "Alnakheel", "branch04" },
                    { 5, "Khobar", "AlDharan", "branch05" }
                });
        }
    }
}
