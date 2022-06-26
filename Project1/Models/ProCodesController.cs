using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project1.Data;

namespace Project1.Models
{
    public class ProCodesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProCodesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProCodes
        public async Task<IActionResult> Index()
        {
              return _context.ProCodes != null ? 
                          View(await _context.ProCodes.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ProCodes'  is null.");
        }

        // GET: ProCodes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProCodes == null)
            {
                return NotFound();
            }

            var proCodes = await _context.ProCodes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proCodes == null)
            {
                return NotFound();
            }

            return View(proCodes);
        }

        // GET: ProCodes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProCodes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Total1,Oasys,AirOptix,BioTrue,BiofinityToric,ACVita,MyDay,proclear")] ProCodes proCodes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proCodes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proCodes);
        }

        // GET: ProCodes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProCodes == null)
            {
                return NotFound();
            }

            var proCodes = await _context.ProCodes.FindAsync(id);
            if (proCodes == null)
            {
                return NotFound();
            }
            return View(proCodes);
        }

        // POST: ProCodes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Total1,Oasys,AirOptix,BioTrue,BiofinityToric,ACVita,MyDay,proclear")] ProCodes proCodes)
        {
            if (id != proCodes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proCodes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProCodesExists(proCodes.Id))
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
            return View(proCodes);
        }

        // GET: ProCodes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProCodes == null)
            {
                return NotFound();
            }

            var proCodes = await _context.ProCodes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proCodes == null)
            {
                return NotFound();
            }

            return View(proCodes);
        }

        // POST: ProCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProCodes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ProCodes'  is null.");
            }
            var proCodes = await _context.ProCodes.FindAsync(id);
            if (proCodes != null)
            {
                _context.ProCodes.Remove(proCodes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProCodesExists(int id)
        {
          return (_context.ProCodes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
