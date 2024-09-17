using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class subaboutnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubAbouts",
                table: "SubAbouts");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "SubAbouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "SubAboutId",
                table: "SubAbouts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubAbouts",
                table: "SubAbouts",
                column: "SubAboutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubAbouts",
                table: "SubAbouts");

            migrationBuilder.DropColumn(
                name: "SubAboutId",
                table: "SubAbouts");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "SubAbouts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubAbouts",
                table: "SubAbouts",
                column: "Title");
        }
    }
}
