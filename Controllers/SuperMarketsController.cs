using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sprint16_EntityFrameworkCore.Data;
using Sprint16_EntityFrameworkCore.Models;

namespace Sprint16_EntityFrameworkCore.Controllers
{
    public class SuperMarketsController : Controller
    {
        private readonly ShoppingContext _context;

        public SuperMarketsController(ShoppingContext context)
        {
            _context = context;
        }

        // GET: SuperMarkets
        public async Task<IActionResult> Index()
        {
              return _context.SuperMarkets != null ? 
                          View(await _context.SuperMarkets.ToListAsync()) :
                          Problem("Entity set 'ShoppingContext.SuperMarkets'  is null.");
        }

        // GET: SuperMarkets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SuperMarkets == null)
            {
                return NotFound();
            }

            var superMarkets = await _context.SuperMarkets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (superMarkets == null)
            {
                return NotFound();
            }

            return View(superMarkets);
        }

        // GET: SuperMarkets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SuperMarkets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address")] SuperMarkets superMarkets)
        {
            if (ModelState.IsValid)
            {
                _context.Add(superMarkets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(superMarkets);
        }

        // GET: SuperMarkets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SuperMarkets == null)
            {
                return NotFound();
            }

            var superMarkets = await _context.SuperMarkets.FindAsync(id);
            if (superMarkets == null)
            {
                return NotFound();
            }
            return View(superMarkets);
        }

        // POST: SuperMarkets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address")] SuperMarkets superMarkets)
        {
            if (id != superMarkets.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(superMarkets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuperMarketsExists(superMarkets.Id))
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
            return View(superMarkets);
        }

        // GET: SuperMarkets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SuperMarkets == null)
            {
                return NotFound();
            }

            var superMarkets = await _context.SuperMarkets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (superMarkets == null)
            {
                return NotFound();
            }

            return View(superMarkets);
        }

        // POST: SuperMarkets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SuperMarkets == null)
            {
                return Problem("Entity set 'ShoppingContext.SuperMarkets'  is null.");
            }
            var superMarkets = await _context.SuperMarkets.FindAsync(id);
            if (superMarkets != null)
            {
                _context.SuperMarkets.Remove(superMarkets);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuperMarketsExists(int id)
        {
          return (_context.SuperMarkets?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
