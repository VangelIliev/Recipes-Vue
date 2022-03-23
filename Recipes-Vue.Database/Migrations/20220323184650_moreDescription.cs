using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipes_Vue.Database.Migrations
{
    public partial class moreDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Likes");

            migrationBuilder.AlterColumn<string>(
                name: "PreparationDescription",
                table: "Recipes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PreparationDescription",
                table: "Recipes",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Likes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
