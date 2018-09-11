using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfDemo1.Migrations
{
    public partial class AddedCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Fruits");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Fruits",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FruitsCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruitsCategorys", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fruits_CategoryId",
                table: "Fruits",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fruits_FruitsCategorys_CategoryId",
                table: "Fruits",
                column: "CategoryId",
                principalTable: "FruitsCategorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fruits_FruitsCategorys_CategoryId",
                table: "Fruits");

            migrationBuilder.DropTable(
                name: "FruitsCategorys");

            migrationBuilder.DropIndex(
                name: "IX_Fruits_CategoryId",
                table: "Fruits");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Fruits");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Fruits",
                nullable: true);
        }
    }
}
