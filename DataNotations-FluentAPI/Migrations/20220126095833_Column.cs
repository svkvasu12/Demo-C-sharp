using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataannotations.Migrations
{
    public partial class Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "MotorCycles",
                newName: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product",
                table: "MotorCycles",
                newName: "Model");
        }
    }
}
