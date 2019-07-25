using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoGiasaWeb.Areas.Catalogos.Controllers;
using ProyectoGiasaWeb.Data;
using ProyectoGiasaWeb.Models;

namespace ProyectoGiasaWeb.Areas.Catalogos
{
    [Area("Catalogos")]
    public class IndirectoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IndirectoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Catalogos/Indirectoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Indirectos.ToListAsync());
        }

        // GET: Catalogos/Indirectoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indirecto = await _context.Indirectos
                .FirstOrDefaultAsync(m => m.idIndirecto == id);
            if (indirecto == null)
            {
                return NotFound();
            }

            return View(indirecto);
        }

        // GET: Catalogos/Indirectoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catalogos/Indirectoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idIndirecto,horas,minutos,importe,subtotalP,insumoV,materialV,subtotalV")] Indirecto indirecto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(indirecto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indirecto);
        }

        // GET: Catalogos/Indirectoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indirecto = await _context.Indirectos.FindAsync(id);
            if (indirecto == null)
            {
                return NotFound();
            }
            return View(indirecto);
        }

        // POST: Catalogos/Indirectoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idIndirecto,horas,minutos,importe,subtotalP,insumoV,materialV,subtotalV")] Indirecto indirecto)
        {
            if (id != indirecto.idIndirecto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indirecto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndirectoExists(indirecto.idIndirecto))
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
            return View(indirecto);
        }

        // GET: Catalogos/Indirectoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indirecto = await _context.Indirectos
                .FirstOrDefaultAsync(m => m.idIndirecto == id);
            if (indirecto == null)
            {
                return NotFound();
            }

            return View(indirecto);
        }

        // POST: Catalogos/Indirectoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var indirecto = await _context.Indirectos.FindAsync(id);
            _context.Indirectos.Remove(indirecto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndirectoExists(int id)
        {
            return _context.Indirectos.Any(e => e.idIndirecto == id);
        }
        public IActionResult Regresa()
        {
            return RedirectToAction(nameof(CatalogosController.Index), "Catalogos");
        }
    }
}
