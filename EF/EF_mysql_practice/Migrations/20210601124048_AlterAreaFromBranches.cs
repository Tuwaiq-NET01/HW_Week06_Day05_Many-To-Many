using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_mysql_practice.Migrations
{
    public partial class AlterAreaFromBranches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branches",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branches",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
