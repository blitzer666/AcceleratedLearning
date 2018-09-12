using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCowboy.Data.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Cowboys_CowboyId",
                table: "Quote");

            migrationBuilder.AlterColumn<int>(
                name: "CowboyId",
                table: "Quote",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Cowboys_CowboyId",
                table: "Quote",
                column: "CowboyId",
                principalTable: "Cowboys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Cowboys_CowboyId",
                table: "Quote");

            migrationBuilder.AlterColumn<int>(
                name: "CowboyId",
                table: "Quote",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Cowboys_CowboyId",
                table: "Quote",
                column: "CowboyId",
                principalTable: "Cowboys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
