using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp3.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_owners_Cars_carId",
                table: "owners");

            migrationBuilder.DropIndex(
                name: "IX_owners_carId",
                table: "owners");

            migrationBuilder.DropColumn(
                name: "carId",
                table: "owners");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_OwnerId",
                table: "Cars",
                column: "OwnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_owners_OwnerId",
                table: "Cars",
                column: "OwnerId",
                principalTable: "owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_owners_OwnerId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_OwnerId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "carId",
                table: "owners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_owners_carId",
                table: "owners",
                column: "carId");

            migrationBuilder.AddForeignKey(
                name: "FK_owners_Cars_carId",
                table: "owners",
                column: "carId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
