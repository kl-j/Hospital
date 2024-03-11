using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital.Data.Entities;

namespace Hospital.Controllers
{
    public class TheHospitalsController : Controller
    {
        private readonly DataContext _context;

        public TheHospitalsController(DataContext context)
        {
            _context = context;
        }

        // GET: TheHospitals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hospitals.ToListAsync());
        }

        // GET: TheHospitals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theHospital = await _context.Hospitals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (theHospital == null)
            {
                return NotFound();
            }

            return View(theHospital);
        }

        // GET: TheHospitals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TheHospitals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HospitalName,Adress,HospitalPhone,Website")] TheHospital theHospital)
        {
            if (ModelState.IsValid)
            {
                _context.Add(theHospital);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(theHospital);
        }

        // GET: TheHospitals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theHospital = await _context.Hospitals.FindAsync(id);
            if (theHospital == null)
            {
                return NotFound();
            }
            return View(theHospital);
        }

        // POST: TheHospitals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HospitalName,Adress,HospitalPhone,Website")] TheHospital theHospital)
        {
            if (id != theHospital.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theHospital);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TheHospitalExists(theHospital.Id))
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
            return View(theHospital);
        }

        // GET: TheHospitals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theHospital = await _context.Hospitals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (theHospital == null)
            {
                return NotFound();
            }

            return View(theHospital);
        }

        // POST: TheHospitals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var theHospital = await _context.Hospitals.FindAsync(id);
            if (theHospital != null)
            {
                _context.Hospitals.Remove(theHospital);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TheHospitalExists(int id)
        {
            return _context.Hospitals.Any(e => e.Id == id);
        }
    }
}
