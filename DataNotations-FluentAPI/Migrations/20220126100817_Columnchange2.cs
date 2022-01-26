using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataannotations.Migrations
{
    public partial class Columnchange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelIda",
                table: "MotorCycles",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "CarsFluent",
                newName: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "MotorCycles",
                newName: "ModelIda");

            migrationBuilder.RenameColumn(
                name: "Product",
                table: "CarsFluent",
                newName: "Model");
        }
    }
}
