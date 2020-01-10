using Microsoft.EntityFrameworkCore.Migrations;

namespace LandR.Migrations
{
    public partial class YourMigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Users_PosterId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Users_TutorId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameIndex(
                name: "IX_Review_TutorId",
                table: "Reviews",
                newName: "IX_Reviews_TutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_PosterId",
                table: "Reviews",
                newName: "IX_Reviews_PosterId");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePic",
                table: "Users",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_PosterId",
                table: "Reviews",
                column: "PosterId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_TutorId",
                table: "Reviews",
                column: "TutorId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_PosterId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_TutorId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_TutorId",
                table: "Review",
                newName: "IX_Review_TutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_PosterId",
                table: "Review",
                newName: "IX_Review_PosterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Users_PosterId",
                table: "Review",
                column: "PosterId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Users_TutorId",
                table: "Review",
                column: "TutorId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
