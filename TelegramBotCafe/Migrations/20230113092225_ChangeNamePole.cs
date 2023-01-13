using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelegramBotCafe.Migrations
{
    public partial class ChangeNamePole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pole",
                table: "Users",
                newName: "UserPole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserPole",
                table: "Users",
                newName: "Pole");
        }
    }
}
