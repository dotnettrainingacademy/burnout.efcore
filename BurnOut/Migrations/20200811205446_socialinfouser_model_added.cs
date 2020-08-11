using Microsoft.EntityFrameworkCore.Migrations;

namespace BurnOut.Migrations
{
    public partial class socialinfouser_model_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialNetworkInfo",
                schema: "burnOut",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaceBook_Profile_URL = table.Column<string>(nullable: true),
                    Instagram_Profile_URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialNetworkInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialNetworkInfo",
                schema: "burnOut");
        }
    }
}
