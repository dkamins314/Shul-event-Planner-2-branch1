﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Shul_Event_Planner_2.Data.Migrations
{
    public partial class migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TitleofSchedule",
                table: "CalendarSetUp",
                newName: "TitleOfSchedule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TitleOfSchedule",
                table: "CalendarSetUp",
                newName: "TitleofSchedule");
        }
    }
}
