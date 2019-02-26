using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Shul_Event_Planner_2.Data;
using Shul_Event_Planner_2.Models;


namespace Shul_Event_Planner_2.Controllers
{
    public class HebrewCalendarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HebrewCalendarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HebrewCalendars
        public async Task<IActionResult> Index()
        {
            return View(await _context.HebrewCalendar.ToListAsync());
        }

        // GET: HebrewCalendars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hebrewCalendar = await _context.HebrewCalendar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hebrewCalendar == null)
            {
                return NotFound();
            }

            return View(hebrewCalendar);
        }

        // GET: HebrewCalendars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HebrewCalendars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CalendarName,TwoDigitYearMax")] System.Globalization.HebrewCalendar hebrewCalendar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hebrewCalendar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hebrewCalendar);
        }

        // GET: HebrewCalendars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hebrewCalendar = await _context.HebrewCalendar.FindAsync(id);
            if (hebrewCalendar == null)
            {
                return NotFound();
            }
            return View(hebrewCalendar);
        }

        // POST: HebrewCalendars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CalendarName,TwoDigitYearMax")] Models.HebrewCalendar hebrewCalendar)
        {
            if (id != hebrewCalendar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hebrewCalendar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HebrewCalendarExists(hebrewCalendar.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hebrewCalendar);
        }

        // GET: HebrewCalendars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hebrewCalendar = await _context.HebrewCalendar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hebrewCalendar == null)
            {
                return NotFound();
            }

            return View(hebrewCalendar);
        }

        // POST: HebrewCalendars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hebrewCalendar = await _context.HebrewCalendar.FindAsync(id);
            _context.HebrewCalendar.Remove(hebrewCalendar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HebrewCalendarExists(int id)
        {
            return _context.HebrewCalendar.Any(e => e.Id == id);
        }
    }
}
