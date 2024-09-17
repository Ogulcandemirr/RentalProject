using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_car_guide_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuidID",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuideId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_GuideId",
                table: "Cars",
                column: "GuideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Guides_GuideId",
                table: "Cars",
                column: "GuideId",
                principalTable: "Guides",
                principalColumn: "GuideId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Guides_GuideId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_GuideId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "GuidID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "GuideId",
                table: "Cars");
        }
    }
}
