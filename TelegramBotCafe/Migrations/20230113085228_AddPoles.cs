using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelegramBotCafe.Migrations
{
    public partial class AddPoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pole",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pole",
                table: "Users");
        }
    }
}
