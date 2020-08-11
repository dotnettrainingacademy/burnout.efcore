using Microsoft.EntityFrameworkCore.Migrations;

namespace BurnOut.Migrations
{
    public partial class user_model_schema_name_modified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "burnOut");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customer",
                newSchema: "burnOut");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Customer",
                schema: "burnOut",
                newName: "Customer");
        }
    }
}
