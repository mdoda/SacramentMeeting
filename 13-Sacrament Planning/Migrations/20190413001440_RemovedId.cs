using Microsoft.EntityFrameworkCore.Migrations;

namespace _13_Sacrament_Planning.Migrations
{
    public partial class RemovedId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpeningHymnID",
                table: "Meeting");

            migrationBuilder.AlterColumn<string>(
                name: "OpeningPrayerMember",
                table: "Meeting",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClosingPrayerMember",
                table: "Meeting",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClosingHymn",
                table: "Meeting",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpeningHymn",
                table: "Meeting",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpeningHymn",
                table: "Meeting");

            migrationBuilder.AlterColumn<string>(
                name: "OpeningPrayerMember",
                table: "Meeting",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ClosingPrayerMember",
                table: "Meeting",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ClosingHymn",
                table: "Meeting",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "OpeningHymnID",
                table: "Meeting",
                nullable: true);
        }
    }
}
