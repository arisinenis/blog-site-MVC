using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSiteMVC.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Topics_TopicId",
                table: "UserInformations");

            migrationBuilder.DropIndex(
                name: "IX_UserInformations_TopicId",
                table: "UserInformations");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "UserInformations");

            migrationBuilder.CreateTable(
                name: "TopicUserInformation",
                columns: table => new
                {
                    TopicsId = table.Column<int>(type: "int", nullable: false),
                    UserInformationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicUserInformation", x => new { x.TopicsId, x.UserInformationsId });
                    table.ForeignKey(
                        name: "FK_TopicUserInformation_Topics_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicUserInformation_UserInformations_UserInformationsId",
                        column: x => x.UserInformationsId,
                        principalTable: "UserInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TopicUserInformation_UserInformationsId",
                table: "TopicUserInformation",
                column: "UserInformationsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopicUserInformation");

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "UserInformations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInformations_TopicId",
                table: "UserInformations",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Topics_TopicId",
                table: "UserInformations",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
