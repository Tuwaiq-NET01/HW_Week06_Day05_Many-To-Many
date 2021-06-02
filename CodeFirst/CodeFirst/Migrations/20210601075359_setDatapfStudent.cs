using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class setDatapfStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Email", "FullName", "LastName" },
                values: new object[] { 1, "NAme@mmm", "Samirah Alhusayni", "ALhusayni" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Email", "FullName", "LastName" },
                values: new object[] { 2, "Nddde@mmm", "Ahmedd Alhusayni", "ALhusayni" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Email", "FullName", "LastName" },
                values: new object[] { 3, "rew@mmm", "Salwa Alhusayni", "ALhusayni" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
