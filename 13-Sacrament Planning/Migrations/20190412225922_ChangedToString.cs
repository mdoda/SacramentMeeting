using Microsoft.EntityFrameworkCore.Migrations;

namespace _13_Sacrament_Planning.Migrations
{
    public partial class ChangedToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosingHymnID",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "ClosingPrayerID",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "OpeningPrayerMemberID",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "SacramentHymnID",
                table: "Meeting");

            migrationBuilder.AlterColumn<string>(
                name: "OpeningHymnID",
                table: "Meeting",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "ClosingHymn",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClosingPrayerMember",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpeningPrayerMember",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SacramentHymn",
                table: "Meeting",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosingHymn",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "ClosingPrayerMember",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "OpeningPrayerMember",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "SacramentHymn",
                table: "Meeting");

            migrationBuilder.AlterColumn<int>(
                name: "OpeningHymnID",
                table: "Meeting",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClosingHymnID",
                table: "Meeting",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClosingPrayerID",
                table: "Meeting",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpeningPrayerMemberID",
                table: "Meeting",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SacramentHymnID",
                table: "Meeting",
                nullable: true);
        }
    }
}
