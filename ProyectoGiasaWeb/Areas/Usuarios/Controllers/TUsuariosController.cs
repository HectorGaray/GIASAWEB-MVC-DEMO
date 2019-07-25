using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoGiasaWeb.Areas.Usuarios.Models;
using ProyectoGiasaWeb.Data;

namespace ProyectoGiasaWeb.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]
    public class TUsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TUsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Usuarios/TUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.TUsuarios.ToListAsync());
        }

        // GET: Usuarios/TUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarios = await _context.TUsuarios
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tUsuarios == null)
            {
                return NotFound();
            }

            return View(tUsuarios);
        }

        // GET: Usuarios/TUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/TUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Apellido,NID,IdUser")] TUsuarios tUsuarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tUsuarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tUsuarios);
        }

        // GET: Usuarios/TUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarios = await _context.TUsuarios.FindAsync(id);
            if (tUsuarios == null)
            {
                return NotFound();
            }
            return View(tUsuarios);
        }

        // POST: Usuarios/TUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Apellido,NID,IdUser")] TUsuarios tUsuarios)
        {
            if (id != tUsuarios.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tUsuarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TUsuariosExists(tUsuarios.ID))
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
            return View(tUsuarios);
        }

        // GET: Usuarios/TUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarios = await _context.TUsuarios
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tUsuarios == null)
            {
                return NotFound();
            }

            return View(tUsuarios);
        }

        // POST: Usuarios/TUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tUsuarios = await _context.TUsuarios.FindAsync(id);
            _context.TUsuarios.Remove(tUsuarios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TUsuariosExists(int id)
        {
            return _context.TUsuarios.Any(e => e.ID == id);
        }
    }
}
