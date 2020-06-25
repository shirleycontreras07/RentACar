using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentCar.Data;
using RentCar.Models.RentCarModels;

namespace RentCar.Controllers
{
    public class TandasController : Controller
    {
        private readonly RentCarDbContext _context;

        public TandasController(RentCarDbContext context)
        {
            _context = context;
        }

        // GET: Tandas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tandas.ToListAsync());
        }

        // GET: Tandas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tanda = await _context.Tandas
                .FirstOrDefaultAsync(m => m.IdTanda == id);
            if (tanda == null)
            {
                return NotFound();
            }

            return View(tanda);
        }

        // GET: Tandas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tandas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTanda,Descripcion,Estado")] Tanda tanda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tanda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tanda);
        }

        // GET: Tandas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tanda = await _context.Tandas.FindAsync(id);
            if (tanda == null)
            {
                return NotFound();
            }
            return View(tanda);
        }

        // POST: Tandas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTanda,Descripcion,Estado")] Tanda tanda)
        {
            if (id != tanda.IdTanda)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tanda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TandaExists(tanda.IdTanda))
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
            return View(tanda);
        }

        // GET: Tandas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tanda = await _context.Tandas
                .FirstOrDefaultAsync(m => m.IdTanda == id);
            if (tanda == null)
            {
                return NotFound();
            }

            return View(tanda);
        }

        // POST: Tandas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tanda = await _context.Tandas.FindAsync(id);
            _context.Tandas.Remove(tanda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TandaExists(int id)
        {
            return _context.Tandas.Any(e => e.IdTanda == id);
        }
    }
}
