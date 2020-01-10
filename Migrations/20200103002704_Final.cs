using Microsoft.EntityFrameworkCore.Migrations;

namespace LandR.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rate",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rate",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
