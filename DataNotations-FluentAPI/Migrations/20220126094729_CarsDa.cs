using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataannotations.Migrations
{
    public partial class CarsDa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "CarsDA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarsDA",
                table: "CarsDA",
                column: "MySpecialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CarsDA",
                table: "CarsDA");

            migrationBuilder.RenameTable(
                name: "CarsDA",
                newName: "Cars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "MySpecialId");
        }
    }
}
