using Microsoft.EntityFrameworkCore.Migrations;

namespace CompatibilityChecker.Data.Migrations
{
    public partial class prices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PartPrice",
                table: "Part",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartPrice",
                table: "Part");
        }
    }
}
