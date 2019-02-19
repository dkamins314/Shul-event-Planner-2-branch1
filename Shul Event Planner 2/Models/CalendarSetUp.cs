using System.ComponentModel.DataAnnotations;
using Shul_Event_Planner_2.ViewModels;
using Zmanim.TimeZone;
using Zmanim.TzDatebase;
using Zmanim.Utilities;


namespace Shul_Event_Planner_2.Models
{
    public class CalendarSetUp
    {
        [Key]
        public int  Id { get; set; }
        public string TitleOfSchedule { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public double GeolocationCoordinates { get; set; }
    }
}
