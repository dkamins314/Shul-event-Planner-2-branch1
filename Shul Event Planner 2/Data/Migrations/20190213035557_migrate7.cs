using Microsoft.EntityFrameworkCore.Migrations;

namespace Shul_Event_Planner_2.Data.Migrations
{
    public partial class migrate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameofSchedule",
                table: "CalendarSetUp",
                newName: "TitleofSchedule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TitleofSchedule",
                table: "CalendarSetUp",
                newName: "NameofSchedule");
        }
    }
}
