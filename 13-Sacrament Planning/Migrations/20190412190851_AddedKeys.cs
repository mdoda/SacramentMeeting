using Microsoft.EntityFrameworkCore.Migrations;

namespace _13_Sacrament_Planning.Migrations
{
    public partial class AddedKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SacramentID",
                table: "Meeting",
                newName: "SacramentHymnID");

            migrationBuilder.RenameColumn(
                name: "BishoppricRole",
                table: "Meeting",
                newName: "BishopricRole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SacramentHymnID",
                table: "Meeting",
                newName: "SacramentID");

            migrationBuilder.RenameColumn(
                name: "BishopricRole",
                table: "Meeting",
                newName: "BishoppricRole");
        }
    }
}
