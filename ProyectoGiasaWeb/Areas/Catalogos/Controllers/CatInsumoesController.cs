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
    public class CatInsumoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CatInsumoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Catalogos/CatInsumoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CatInsumo.ToListAsync());
        }

        // GET: Catalogos/CatInsumoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catInsumo = await _context.CatInsumo
                .FirstOrDefaultAsync(m => m.idCatinsumo == id);
            if (catInsumo == null)
            {
                return NotFound();
            }

            return View(catInsumo);
        }

        // GET: Catalogos/CatInsumoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catalogos/CatInsumoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idCatinsumo,insumo,costohr")] CatInsumo catInsumo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catInsumo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catInsumo);
        }

        // GET: Catalogos/CatInsumoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catInsumo = await _context.CatInsumo.FindAsync(id);
            if (catInsumo == null)
            {
                return NotFound();
            }
            return View(catInsumo);
        }

        // POST: Catalogos/CatInsumoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCatinsumo,insumo,costohr")] CatInsumo catInsumo)
        {
            if (id != catInsumo.idCatinsumo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catInsumo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatInsumoExists(catInsumo.idCatinsumo))
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
            return View(catInsumo);
        }

        // GET: Catalogos/CatInsumoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catInsumo = await _context.CatInsumo
                .FirstOrDefaultAsync(m => m.idCatinsumo == id);
            if (catInsumo == null)
            {
                return NotFound();
            }

            return View(catInsumo);
        }

        // POST: Catalogos/CatInsumoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catInsumo = await _context.CatInsumo.FindAsync(id);
            _context.CatInsumo.Remove(catInsumo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Regresa()
        {
            return RedirectToAction(nameof(CatalogosController.Index), "Catalogos");
        }
        private bool CatInsumoExists(int id)
        {
            return _context.CatInsumo.Any(e => e.idCatinsumo == id);
        }
    }
}
