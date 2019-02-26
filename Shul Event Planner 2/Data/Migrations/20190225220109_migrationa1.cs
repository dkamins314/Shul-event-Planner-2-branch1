using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shul_Event_Planner_2.Data.Migrations
{
    public partial class migrationa1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HolidayName",
                table: "HebrewCalendar",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HolidayStart",
                table: "HebrewCalendar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MaarivStart",
                table: "HebrewCalendar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MinchaStart",
                table: "HebrewCalendar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ParshaName",
                table: "HebrewCalendar",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ShabbosStart",
                table: "HebrewCalendar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShacharisStart",
                table: "HebrewCalendar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HolidayName",
                table: "HebrewCalendar");

            migrationBuilder.DropColumn(
                name: "HolidayStart",
                table: "HebrewCalendar");

            migrationBuilder.DropColumn(
                name: "MaarivStart",
                table: "HebrewCalendar");

            migrationBuilder.DropColumn(
                name: "MinchaStart",
                table: "HebrewCalendar");

            migrationBuilder.DropColumn(
                name: "ParshaName",
                table: "HebrewCalendar");

            migrationBuilder.DropColumn(
                name: "ShabbosStart",
                table: "HebrewCalendar");

            migrationBuilder.DropColumn(
                name: "ShacharisStart",
                table: "HebrewCalendar");
        }
    }
}
