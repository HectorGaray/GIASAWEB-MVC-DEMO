using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoGiasaWeb.Data;
using ProyectoGiasaWeb.Models;

namespace ProyectoGiasaWeb.Areas.Materiales.Controllers
{
    [Area("Materiales")]
    public class PapelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PapelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Materiales/Papels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Papel.ToListAsync());
        }

        // GET: Materiales/Papels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var papel = await _context.Papel
                .FirstOrDefaultAsync(m => m.idPapel == id);
            if (papel == null)
            {
                return NotFound();
            }

            return View(papel);
        }

        // GET: Materiales/Papels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Materiales/Papels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idPapel,nombre,precio")] Papel papel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(papel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(papel);
        }

        // GET: Materiales/Papels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var papel = await _context.Papel.FindAsync(id);
            if (papel == null)
            {
                return NotFound();
            }
            return View(papel);
        }

        // POST: Materiales/Papels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idPapel,nombre,precio")] Papel papel)
        {
            if (id != papel.idPapel)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(papel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PapelExists(papel.idPapel))
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
            return View(papel);
        }

        // GET: Materiales/Papels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var papel = await _context.Papel
                .FirstOrDefaultAsync(m => m.idPapel == id);
            if (papel == null)
            {
                return NotFound();
            }

            return View(papel);
        }

        // POST: Materiales/Papels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var papel = await _context.Papel.FindAsync(id);
            _context.Papel.Remove(papel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PapelExists(int id)
        {
            return _context.Papel.Any(e => e.idPapel == id);
        }
    }
}
