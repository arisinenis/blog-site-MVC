using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSiteMVC.Migrations
{
    public partial class DbUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalReading",
                table: "Topics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalReading",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalReading",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "TotalReading",
                table: "Articles");
        }
    }
}
