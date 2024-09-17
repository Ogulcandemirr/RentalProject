using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_new_guide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Guides_GuideId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "GuidID",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "GuideId",
                table: "Cars",
                newName: "GuideID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_GuideId",
                table: "Cars",
                newName: "IX_Cars_GuideID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Guides_GuideID",
                table: "Cars",
                column: "GuideID",
                principalTable: "Guides",
                principalColumn: "GuideId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Guides_GuideID",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "GuideID",
                table: "Cars",
                newName: "GuideId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_GuideID",
                table: "Cars",
                newName: "IX_Cars_GuideId");

            migrationBuilder.AddColumn<int>(
                name: "GuidID",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Guides_GuideId",
                table: "Cars",
                column: "GuideId",
                principalTable: "Guides",
                principalColumn: "GuideId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
