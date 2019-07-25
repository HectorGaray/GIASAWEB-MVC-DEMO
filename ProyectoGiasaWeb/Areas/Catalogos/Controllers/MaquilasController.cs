using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoGiasaWeb.Data;
using ProyectoGiasaWeb.Models;

namespace ProyectoGiasaWeb.Areas.Catalogos.Controllers
{
    [Area("Catalogos")]
    public class MaquilasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaquilasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Catalogos/Maquilas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Maquilas.ToListAsync());
        }

        // GET: Catalogos/Maquilas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maquilas = await _context.Maquilas
                .FirstOrDefaultAsync(m => m.idMaquila == id);
            if (maquilas == null)
            {
                return NotFound();
            }

            return View(maquilas);
        }

        // GET: Catalogos/Maquilas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catalogos/Maquilas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idMaquila,nombreMaq,precio")] Maquilas maquilas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maquilas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maquilas);
        }

        // GET: Catalogos/Maquilas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maquilas = await _context.Maquilas.FindAsync(id);
            if (maquilas == null)
            {
                return NotFound();
            }
            return View(maquilas);
        }

        // POST: Catalogos/Maquilas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idMaquila,nombreMaq,precio")] Maquilas maquilas)
        {
            if (id != maquilas.idMaquila)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maquilas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaquilasExists(maquilas.idMaquila))
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
            return View(maquilas);
        }

        // GET: Catalogos/Maquilas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maquilas = await _context.Maquilas
                .FirstOrDefaultAsync(m => m.idMaquila == id);
            if (maquilas == null)
            {
                return NotFound();
            }

            return View(maquilas);
        }

        // POST: Catalogos/Maquilas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maquilas = await _context.Maquilas.FindAsync(id);
            _context.Maquilas.Remove(maquilas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaquilasExists(int id)
        {
            return _context.Maquilas.Any(e => e.idMaquila == id);
        }
        public IActionResult Regresa()
        {
            return RedirectToAction(nameof(CatalogosController.Index), "Catalogos");
        }
    }
}
