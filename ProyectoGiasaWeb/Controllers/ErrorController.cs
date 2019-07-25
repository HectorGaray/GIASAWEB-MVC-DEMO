using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoGiasaWeb.Controllers
{
   // [Route("/Error")] // ruta personalizada
    public class ErrorController : Controller
    {
        public IActionResult Error(int? statusCode = null)// ?cambio de Direccion del nombre Error GET
        {
            if (statusCode.HasValue)// Valor tipo entero o null
            {
                if (statusCode.Value == 404 || statusCode.Value==500)/// error no foud & de servidor
                {
                    ViewData["Error"] = statusCode.ToString();//de controlador a vistas
                }
            }
            return View();
        }
    }
}