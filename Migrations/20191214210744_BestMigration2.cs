using Microsoft.EntityFrameworkCore.Migrations;

namespace LandR.Migrations
{
    public partial class BestMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rate",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Schedule",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "Users");
        }
    }
}
