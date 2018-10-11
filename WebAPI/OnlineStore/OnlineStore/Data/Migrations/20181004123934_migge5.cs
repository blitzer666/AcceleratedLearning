using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineStore.Data.Migrations
{
    public partial class migge5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kjell",
                table: "Product");

            migrationBuilder.AddColumn<bool>(
                name: "Forsales",
                table: "Product",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Forsales",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Kjell",
                table: "Product",
                nullable: true);
        }
    }
}
