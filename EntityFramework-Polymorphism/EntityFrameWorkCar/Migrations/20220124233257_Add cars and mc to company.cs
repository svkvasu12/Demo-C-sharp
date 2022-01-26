using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWorkCar.Migrations
{
    public partial class Addcarsandmctocompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "MotorCycles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MotorCycles_CompanyId",
                table: "MotorCycles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CompanyId",
                table: "Cars",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_companies_CompanyId",
                table: "Cars",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MotorCycles_companies_CompanyId",
                table: "MotorCycles",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_companies_CompanyId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_MotorCycles_companies_CompanyId",
                table: "MotorCycles");

            migrationBuilder.DropIndex(
                name: "IX_MotorCycles_CompanyId",
                table: "MotorCycles");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CompanyId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "MotorCycles");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Cars");
        }
    }
}
