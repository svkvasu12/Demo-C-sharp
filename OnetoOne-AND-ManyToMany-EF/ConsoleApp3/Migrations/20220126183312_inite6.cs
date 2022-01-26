using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp3.Migrations
{
    public partial class inite6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarOwner_Cars_carsId",
                table: "CarOwner");

            migrationBuilder.RenameColumn(
                name: "carsId",
                table: "CarOwner",
                newName: "CarsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarOwner_Cars_CarsId",
                table: "CarOwner",
                column: "CarsId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarOwner_Cars_CarsId",
                table: "CarOwner");

            migrationBuilder.RenameColumn(
                name: "CarsId",
                table: "CarOwner",
                newName: "carsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarOwner_Cars_carsId",
                table: "CarOwner",
                column: "carsId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
