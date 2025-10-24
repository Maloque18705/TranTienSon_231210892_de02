using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranTienSon_231210892_de02.Database;
using TranTienSon_231210892_de02.Models;

namespace TranTienSon_231210892_de02.Controllers
{
    public class TtsCatalogsController : Controller
    {
        private readonly AppDbContext _context;

        public TtsCatalogsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TtsCatalogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TtsCatalogs.ToListAsync());
        }

        // GET: TtsCatalogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ttsCatalog = await _context.TtsCatalogs
                .FirstOrDefaultAsync(m => m.TtsId == id);
            if (ttsCatalog == null)
            {
                return NotFound();
            }

            return View(ttsCatalog);
        }

        // GET: TtsCatalogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TtsCatalogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TtsId,TtsCateName,TtsCatePrice,TtsCateQty,TtsPicture,TtsCateActive")] TtsCatalog ttsCatalog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ttsCatalog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ttsCatalog);
        }

        // GET: TtsCatalogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ttsCatalog = await _context.TtsCatalogs.FindAsync(id);
            if (ttsCatalog == null)
            {
                return NotFound();
            }
            return View(ttsCatalog);
        }

        // POST: TtsCatalogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TtsId,TtsCateName,TtsCatePrice,TtsCateQty,TtsPicture,TtsCateActive")] TtsCatalog ttsCatalog)
        {
            if (id != ttsCatalog.TtsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ttsCatalog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TtsCatalogExists(ttsCatalog.TtsId))
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
            return View(ttsCatalog);
        }

        // GET: TtsCatalogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ttsCatalog = await _context.TtsCatalogs
                .FirstOrDefaultAsync(m => m.TtsId == id);
            if (ttsCatalog == null)
            {
                return NotFound();
            }

            return View(ttsCatalog);
        }

        // POST: TtsCatalogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ttsCatalog = await _context.TtsCatalogs.FindAsync(id);
            if (ttsCatalog != null)
            {
                _context.TtsCatalogs.Remove(ttsCatalog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TtsCatalogExists(int id)
        {
            return _context.TtsCatalogs.Any(e => e.TtsId == id);
        }
    }
}
