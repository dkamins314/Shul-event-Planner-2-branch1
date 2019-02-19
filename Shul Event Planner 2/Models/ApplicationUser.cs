using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shul_Event_Planner_2.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string ContactName { get; set; }
        [PersonalData]
        public string NameofOrganization { get; set; }
        [PersonalData]
        public string StreetAddressOfOrganization { get; set; }
        [PersonalData]
        public string ZipCode { get; set; }
        [PersonalData]
        public string City { get; set; }
        [PersonalData]
        public string State { get; set; }
        [PersonalData]
        public string Country { get; set; }
    }
}


