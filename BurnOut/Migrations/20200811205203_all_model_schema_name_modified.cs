using Microsoft.EntityFrameworkCore.Migrations;

namespace BurnOut.Migrations
{
    public partial class all_model_schema_name_modified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                schema: "burnOut",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments");

            migrationBuilder.RenameTable(
                name: "Workouts",
                newName: "Workouts",
                newSchema: "burnOut");

            migrationBuilder.RenameTable(
                name: "Muscles",
                newName: "Muscles",
                newSchema: "burnOut");

            migrationBuilder.RenameTable(
                name: "Excercises",
                newName: "Excercises",
                newSchema: "burnOut");

            migrationBuilder.RenameTable(
                name: "Customer",
                schema: "burnOut",
                newName: "Customers",
                newSchema: "burnOut");

            migrationBuilder.RenameTable(
                name: "Equipments",
                newName: "Equipment",
                newSchema: "burnOut");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                schema: "burnOut",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                schema: "burnOut",
                table: "Equipment",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                schema: "burnOut",
                table: "Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                schema: "burnOut",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Workouts",
                schema: "burnOut",
                newName: "Workouts");

            migrationBuilder.RenameTable(
                name: "Muscles",
                schema: "burnOut",
                newName: "Muscles");

            migrationBuilder.RenameTable(
                name: "Excercises",
                schema: "burnOut",
                newName: "Excercises");

            migrationBuilder.RenameTable(
                name: "Equipment",
                schema: "burnOut",
                newName: "Equipments");

            migrationBuilder.RenameTable(
                name: "Customers",
                schema: "burnOut",
                newName: "Customer",
                newSchema: "burnOut");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                schema: "burnOut",
                table: "Customer",
                column: "Id");
        }
    }
}
