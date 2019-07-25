using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoGiasaWeb.Areas.Catalogos.Controllers
{
    [Area("Catalogos")]
    public class CatalogosController : Controller
    {
        // GET: Catalogos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Catalogos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Catalogos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catalogos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalogos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Catalogos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalogos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catalogos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}