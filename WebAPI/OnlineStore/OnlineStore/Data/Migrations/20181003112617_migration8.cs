using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineStore.Data.Migrations
{
    public partial class migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Food",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Tools",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Toys",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CatergoryId",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categories",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatergoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "Food",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tools",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Toys",
                table: "Categories",
                nullable: true);
        }
    }
}
