using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using ProyectoGiasaWeb.Areas.Principal.Controllers;
using ProyectoGiasaWeb.Data;
using ProyectoGiasaWeb.Library;
using ProyectoGiasaWeb.Models;

namespace ProyectoGiasaWeb.Controllers
{
    public class HomeController : Controller
    {
        private LUsuarios usuarios;// objecto para el manejo de datos
        private SignInManager<IdentityUser> _signInManager;// Manejador de Inicio de Session
        public HomeController(UserManager<IdentityUser> userManager,// Parametros ---> LayoutPricipal
            SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager,ApplicationDbContext context)
        {
            //CreateRoles(serviceProvider);
            _signInManager = signInManager;// Aterrizar a <---singInManager de asp
            usuarios = new LUsuarios(userManager, signInManager, roleManager,context);
        }

        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))// comprobar que el usuario siga la en login 1
            {
                return RedirectToAction(nameof(PrincipalController.Index), "Principal");// Redireccionamiento a Principal
            }
            else
            {
                return View();
            }
            
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(LoginViewModels model)// modelo como parametro 
        {
            if (ModelState.IsValid)// verifica que no hay error en datos 
            {
                List<object[]> listObject = await usuarios.userLogin(model.input.Email, model.input.Password);// esto viene de la vista
                object[] objects = listObject[0];// Posicion 0 retorna si hay error
                var _identityError = (IdentityError)objects[0];// error que se guardo en la p 0
                model.ErroMessage = _identityError.Description;
                if (model.ErroMessage.Equals("True"))
                {
                   // regreso correctamente
                    var data = JsonConvert.SerializeObject(objects[1]);//serialiar el usuario y rol

                   HttpContext.Session.SetString("User",data);
                    return RedirectToAction(nameof(PrincipalController.Index), "Principal");// pasa como parametro data que contiene los datos del login
                   
                   
                }
                else
                {
                    return View(model);//propiedad model contiene objects con los datos del vendedor ERROR
                }
            }
            return View(model);



        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


      

        // Primer Rol del sistema  NO SE USA  
        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            String[] rolesName = { "Admin", "User" };
            foreach (var item in rolesName)
            {
                var roleExiste = await roleManager.RoleExistsAsync(item);
                if (!roleExiste)
                {
                    await roleManager.CreateAsync(new IdentityRole(item));
                }
            }
            // registro Primer Usuario
            var user = await userManager.FindByIdAsync("9e451eeb-6b22-41c8-b6e5-794dc1994e23");
            await userManager.AddToRoleAsync(user, "Admin");// agregar roles a usuario 
        }

    }
}
