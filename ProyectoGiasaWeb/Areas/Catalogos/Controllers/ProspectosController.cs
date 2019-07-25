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
    public class ProspectosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProspectosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Catalogos/Prospectos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prospectos.ToListAsync());
        }

        // GET: Catalogos/Prospectos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prospectos = await _context.Prospectos
                .FirstOrDefaultAsync(m => m.idProspecto == id);
            if (prospectos == null)
            {
                return NotFound();
            }

            return View(prospectos);
        }

        // GET: Catalogos/Prospectos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catalogos/Prospectos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idProspecto,nombrepros,ap_materno,ap_paterno,direccion,correo,empresa")] Prospectos prospectos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prospectos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prospectos);
        }

        // GET: Catalogos/Prospectos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prospectos = await _context.Prospectos.FindAsync(id);
            if (prospectos == null)
            {
                return NotFound();
            }
            return View(prospectos);
        }

        // POST: Catalogos/Prospectos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idProspecto,nombrepros,ap_materno,ap_paterno,direccion,correo,empresa")] Prospectos prospectos)
        {
            if (id != prospectos.idProspecto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prospectos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProspectosExists(prospectos.idProspecto))
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
            return View(prospectos);
        }

        // GET: Catalogos/Prospectos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prospectos = await _context.Prospectos
                .FirstOrDefaultAsync(m => m.idProspecto == id);
            if (prospectos == null)
            {
                return NotFound();
            }

            return View(prospectos);
        }

        // POST: Catalogos/Prospectos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prospectos = await _context.Prospectos.FindAsync(id);
            _context.Prospectos.Remove(prospectos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProspectosExists(int id)
        {
            return _context.Prospectos.Any(e => e.idProspecto == id);
        }
        public IActionResult Regresa()
        {
            return RedirectToAction(nameof(CatalogosController.Index), "Catalogos");
        }
    }
}
