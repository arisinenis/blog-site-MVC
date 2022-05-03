using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSiteMVC.Migrations
{
    public partial class ExceptUserPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserRegisters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserRegisters",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
