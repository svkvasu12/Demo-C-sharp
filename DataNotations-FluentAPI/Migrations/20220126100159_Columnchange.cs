using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataannotations.Migrations
{
    public partial class Columnchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product",
                table: "MotorCycles",
                newName: "ModelIda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelIda",
                table: "MotorCycles",
                newName: "Product");
        }
    }
}
