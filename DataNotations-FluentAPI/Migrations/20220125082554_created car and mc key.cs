using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataannotations.Migrations
{
    public partial class createdcarandmckey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cars",
                newName: "MySpecialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MySpecialId",
                table: "Cars",
                newName: "Id");
        }
    }
}
