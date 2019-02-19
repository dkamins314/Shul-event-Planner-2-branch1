using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shul_Event_Planner_2.Models;

namespace Shul_Event_Planner_2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<ApplicationUser> AppUsers { get; set; }
         public DbSet<Shul_Event_Planner_2.Models.CalendarSetUp> CalendarSetUp { get; set; }
         public DbSet<Shul_Event_Planner_2.Models.HebrewCalendar> HebrewCalendar { get; set; }
    }
}
