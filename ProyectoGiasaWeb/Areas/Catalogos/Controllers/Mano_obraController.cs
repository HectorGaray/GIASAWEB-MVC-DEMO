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
    public class Mano_obraController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Mano_obraController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Catalogos/Mano_obra
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mano_obra.ToListAsync());
        }

        // GET: Catalogos/Mano_obra/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mano_obra = await _context.Mano_obra
                .FirstOrDefaultAsync(m => m.idmano == id);
            if (mano_obra == null)
            {
                return NotFound();
            }

            return View(mano_obra);
        }

        // GET: Catalogos/Mano_obra/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catalogos/Mano_obra/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idmano,minDiseno,costoDiseño,minPrensa,costoPren,minFoliador,minterminado,costoFolio,costoTerminado,subtotal")] Mano_obra mano_obra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mano_obra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mano_obra);
        }

        // GET: Catalogos/Mano_obra/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mano_obra = await _context.Mano_obra.FindAsync(id);
            if (mano_obra == null)
            {
                return NotFound();
            }
            return View(mano_obra);
        }

        // POST: Catalogos/Mano_obra/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idmano,minDiseno,costoDiseño,minPrensa,costoPren,minFoliador,minterminado,costoFolio,costoTerminado,subtotal")] Mano_obra mano_obra)
        {
            if (id != mano_obra.idmano)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mano_obra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Mano_obraExists(mano_obra.idmano))
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
            return View(mano_obra);
        }

        // GET: Catalogos/Mano_obra/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mano_obra = await _context.Mano_obra
                .FirstOrDefaultAsync(m => m.idmano == id);
            if (mano_obra == null)
            {
                return NotFound();
            }

            return View(mano_obra);
        }

        // POST: Catalogos/Mano_obra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mano_obra = await _context.Mano_obra.FindAsync(id);
            _context.Mano_obra.Remove(mano_obra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Mano_obraExists(int id)
        {
            return _context.Mano_obra.Any(e => e.idmano == id);
        }
        public IActionResult Regresa()
        {
            return RedirectToAction(nameof(CatalogosController.Index), "Catalogos");
        }
    }
}
