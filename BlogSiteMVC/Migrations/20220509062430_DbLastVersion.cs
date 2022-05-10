using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSiteMVC.Migrations
{
    public partial class DbLastVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleTopic");

            migrationBuilder.DropTable(
                name: "TopicUserInformation");

            migrationBuilder.CreateTable(
                name: "ArticleAndTopics",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleAndTopics", x => new { x.ArticleId, x.TopicId });
                    table.ForeignKey(
                        name: "FK_ArticleAndTopics_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleAndTopics_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAndTopics",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAndTopics", x => new { x.UserId, x.TopicId });
                    table.ForeignKey(
                        name: "FK_UserAndTopics_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAndTopics_UserInformations_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleAndTopics_TopicId",
                table: "ArticleAndTopics",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAndTopics_TopicId",
                table: "UserAndTopics",
                column: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleAndTopics");

            migrationBuilder.DropTable(
                name: "UserAndTopics");

            migrationBuilder.CreateTable(
                name: "ArticleTopic",
                columns: table => new
                {
                    ArticlesId = table.Column<int>(type: "int", nullable: false),
                    TopicsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTopic", x => new { x.ArticlesId, x.TopicsId });
                    table.ForeignKey(
                        name: "FK_ArticleTopic_Articles_ArticlesId",
                        column: x => x.ArticlesId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTopic_Topics_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_ArticleTopic_TopicsId",
                table: "ArticleTopic",
                column: "TopicsId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicUserInformation_UserInformationsId",
                table: "TopicUserInformation",
                column: "UserInformationsId");
        }
    }
}
