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
    public class Cat_tintaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Cat_tintaController(ApplicationDbContext context)
        {
            _context = context;
        }
        
       

        // GET: Catalogos/Cat_tinta
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cat_tinta.ToListAsync());
        }

        public IActionResult Regresa()
        {
            return RedirectToAction(nameof(CatalogosController.Index), "Catalogos");
        }


        // GET: Catalogos/Cat_tinta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cat_tinta = await _context.Cat_tinta
                .FirstOrDefaultAsync(m => m.idTinta == id);
            if (cat_tinta == null)
            {
                return NotFound();
            }

            return View(cat_tinta);
        }

        // GET: Catalogos/Cat_tinta/Create
        public IActionResult Create()
        {
            return View();
        }

      

        // POST: Catalogos/Cat_tinta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idTinta,nombretin,precio")] Cat_tinta cat_tinta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cat_tinta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cat_tinta);
        }

        // GET: Catalogos/Cat_tinta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cat_tinta = await _context.Cat_tinta.FindAsync(id);
            if (cat_tinta == null)
            {
                return NotFound();
            }
            return View(cat_tinta);
        }

        // POST: Catalogos/Cat_tinta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idTinta,nombretin,precio")] Cat_tinta cat_tinta)
        {
            if (id != cat_tinta.idTinta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cat_tinta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Cat_tintaExists(cat_tinta.idTinta))
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
            return View(cat_tinta);
        }

        // GET: Catalogos/Cat_tinta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cat_tinta = await _context.Cat_tinta
                .FirstOrDefaultAsync(m => m.idTinta == id);
            if (cat_tinta == null)
            {
                return NotFound();
            }

            return View(cat_tinta);
        }

        // POST: Catalogos/Cat_tinta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cat_tinta = await _context.Cat_tinta.FindAsync(id);
            _context.Cat_tinta.Remove(cat_tinta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Cat_tintaExists(int id)
        {
            return _context.Cat_tinta.Any(e => e.idTinta == id);
        }



    }
}
