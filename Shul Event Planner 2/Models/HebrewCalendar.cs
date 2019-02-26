using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Threading;


namespace Shul_Event_Planner_2.Models
{


    public class HebrewCalendar : System.Globalization.Calendar
    {
        public HebrewCalendar()
        {
        }

        public int Id { get; set; }
        public string CalendarName { get; set; }
        public string ParshaName { get; set; }
        public string HolidayName { get; set; }
        public DateTime ShabbosStart { get; set; }
        public DateTime HolidayStart { get; set; }
        public DateTime ShacharisStart { get; set; }
        public DateTime MinchaStart { get; set; }
        public DateTime MaarivStart { get; set; }



        public override DateTime AddMonths(DateTime time, int months)
        {
            throw new NotImplementedException();
        }

        public override DateTime AddYears(DateTime time, int years)
        {
            throw new NotImplementedException();
        }

        public override int GetDayOfMonth(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override DayOfWeek GetDayOfWeek(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetDayOfYear(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetDaysInMonth(int year, int month, int era)
        {
            throw new NotImplementedException();
        }

        public override int GetDaysInYear(int year, int era)
        {
            throw new NotImplementedException();
        }

        public override int GetEra(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetMonth(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetMonthsInYear(int year, int era)
        {
            throw new NotImplementedException();
        }

        public override int GetYear(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override bool IsLeapDay(int year, int month, int day, int era)
        {
            throw new NotImplementedException();
        }

        public override bool IsLeapMonth(int year, int month, int era)
        {
            throw new NotImplementedException();
        }

        public override bool IsLeapYear(int year, int era)
        {
            throw new NotImplementedException();
        }

        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
        {
            throw new NotImplementedException();
        }
        public override int[] Eras { get; }


    }
}
