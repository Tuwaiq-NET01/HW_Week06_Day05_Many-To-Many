using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFristApp.Migrations
{
    public partial class makeAreeaRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branch",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branch",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
