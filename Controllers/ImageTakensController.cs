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
    public class ImageTakensController : Controller
    {
        private readonly DataContext _context;

        public ImageTakensController(DataContext context)
        {
            _context = context;
        }

        // GET: ImageTakens
        public async Task<IActionResult> Index()
        {
            return View(await _context.ImagesTaken.ToListAsync());
        }

        // GET: ImageTakens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageTaken = await _context.ImagesTaken
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imageTaken == null)
            {
                return NotFound();
            }

            return View(imageTaken);
        }

        // GET: ImageTakens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ImageTakens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImageUrl,Description,DateHour,Paciente")] ImageTaken imageTaken)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imageTaken);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imageTaken);
        }

        // GET: ImageTakens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageTaken = await _context.ImagesTaken.FindAsync(id);
            if (imageTaken == null)
            {
                return NotFound();
            }
            return View(imageTaken);
        }

        // POST: ImageTakens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImageUrl,Description,DateHour,Paciente")] ImageTaken imageTaken)
        {
            if (id != imageTaken.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imageTaken);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImageTakenExists(imageTaken.Id))
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
            return View(imageTaken);
        }

        // GET: ImageTakens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imageTaken = await _context.ImagesTaken
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imageTaken == null)
            {
                return NotFound();
            }

            return View(imageTaken);
        }

        // POST: ImageTakens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imageTaken = await _context.ImagesTaken.FindAsync(id);
            if (imageTaken != null)
            {
                _context.ImagesTaken.Remove(imageTaken);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImageTakenExists(int id)
        {
            return _context.ImagesTaken.Any(e => e.Id == id);
        }
    }
}
