using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataannotations.Migrations
{
    public partial class Carsfluent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CarsDA",
                table: "CarsDA");

            migrationBuilder.RenameTable(
                name: "CarsDA",
                newName: "CarsFluent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarsFluent",
                table: "CarsFluent",
                column: "MySpecialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CarsFluent",
                table: "CarsFluent");

            migrationBuilder.RenameTable(
                name: "CarsFluent",
                newName: "CarsDA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarsDA",
                table: "CarsDA",
                column: "MySpecialId");
        }
    }
}
