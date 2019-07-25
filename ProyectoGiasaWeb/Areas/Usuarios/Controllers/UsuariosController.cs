using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoGiasaWeb.Controllers;
using ProyectoGiasaWeb.Library;

namespace ProyectoGiasaWeb.Areas.Usuarios.Controllers
{   [Authorize]
    [Area("Usuarios")]
    public class UsuariosController : Controller
    {
        private readonly LUsuarios _usuarios;
        private ListObject objeto;
        private readonly SignInManager<IdentityUser> _signInManager;
        public UsuariosController(SignInManager<IdentityUser> signInManager)
        {
            _usuarios = new LUsuarios();
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                // ViewData["Role"] = _usuarios.userData(HttpContext);
               

                

               
                return View();

            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
        public async Task<IActionResult> SessionClose()
        {
            HttpContext.Session.Remove("User");
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");


        }
    }
}