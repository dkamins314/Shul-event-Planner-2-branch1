using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shul_Event_Planner_2.Data;
using Shul_Event_Planner_2.Models;
using Shul_Event_Planner_2.ViewModels;


namespace Shul_Event_Planner_2.Controllers
{
    public class CalendarSetUpController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalendarSetUpController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CalendarSetUps
        public async Task<IActionResult> Index()
        {
            return View(await _context.CalendarSetUp.ToListAsync());
        }

        // GET: CalendarSetUps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendarSetUp = await _context.CalendarSetUp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendarSetUp == null)
            {
                return NotFound();
            }

            return View(calendarSetUp);
        }

        // GET: CalendarSetUps/Create
        public IActionResult Create()
        { 
        CalendarSetUpViewModel calendarSetUpViewModel =
            new CalendarSetUpViewModel();

        
            return View(calendarSetUpViewModel);
        }

        // POST: CalendarSetUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TitleOfScheduleS,Address,City,ZipCode,Country,GeolocationCoordinates")] CalendarSetUp calendarSetUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calendarSetUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("/Index");
        }

        // GET: CalendarSetUps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendarSetUp = await _context.CalendarSetUp.FindAsync(id);
            if (calendarSetUp == null)
            {
                return NotFound();
            }
            return View(calendarSetUp);
        }

        // POST: CalendarSetUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Address,City,ZipCode,Country,GeolocationCoordinates")] CalendarSetUp calendarSetUp)
        {
            if (id != calendarSetUp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calendarSetUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalendarSetUpExists(calendarSetUp.Id))
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
            return View(calendarSetUp);
        }

        // GET: CalendarSetUps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendarSetUp = await _context.CalendarSetUp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendarSetUp == null)
            {
                return NotFound();
            }

            return View(calendarSetUp);
        }

        // POST: CalendarSetUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calendarSetUp = await _context.CalendarSetUp.FindAsync(id);
            _context.CalendarSetUp.Remove(calendarSetUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalendarSetUpExists(int id)
        {
            return _context.CalendarSetUp.Any(e => e.Id == id);
        }
    }
}
