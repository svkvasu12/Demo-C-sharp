using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp3.Migrations
{
    public partial class inite5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CarOwner",
                columns: table => new
                {
                    carsId = table.Column<int>(type: "int", nullable: false),
                    ownersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarOwner", x => new { x.carsId, x.ownersId });
                    table.ForeignKey(
                        name: "FK_CarOwner_Cars_carsId",
                        column: x => x.carsId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarOwner_owners_ownersId",
                        column: x => x.ownersId,
                        principalTable: "owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarOwner_ownersId",
                table: "CarOwner",
                column: "ownersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarOwner");

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
    }
}
