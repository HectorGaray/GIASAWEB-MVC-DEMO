using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoGiasaWeb.Areas.Usuarios.Models;
using ProyectoGiasaWeb.Library;
using ProyectoGiasaWeb.Areas.Usuarios.Controllers;
using ProyectoGiasaWeb.Data;

namespace ProyectoGiasaWeb.Areas.Usuarios.Pages.Registrar
{
    
    public class RegistrarModel : PageModel
    {
        //private LUsuarios _usuarios;
        private ListObject objecto = new ListObject();

        public RegistrarModel(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ApplicationDbContext contex)
        {
            objecto._roleManger = roleManager;
            objecto._userManager = userManager;
            objecto._usuarios = new LUsuarios();
            objecto._usersRole= new UsersRoles();
            objecto._context = contex;
            
            objecto._userRoles = new List<SelectListItem>();

        }
        public void OnGet()
        {

            Input = new InputModel
            {
                rolesLista = objecto._usersRole.getRoles(objecto._roleManger) //aqui saca todos
            };
             //_usuarios = new LUsuarios();
          //  listObject._usuarios = new LUsuarios();
           // ViewData["Role"] = listObject._usuarios.UserData(HttpContext);
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel: InputModelRegistrar// herencia de modelo
        {
            [Required]
            public string Role { get; set; }
            
            [TempData]
            public string ErrorMessage { get; set; }


            public List<SelectListItem> rolesLista { get; set; }

        }


        public async Task<IActionResult> OnPostAsync()
        {



            if (await guardarAsync())
            {
               return RedirectToAction(nameof(UsuariosController.Index), "Usuarios");
            }



            return Page();
        }

        public async Task<bool> guardarAsync()
        {
            var valor = false;
            try
            {
                if (ModelState.IsValid)
                {
                    objecto._userRoles.Add(new SelectListItem
                    {
                        Text = Input.Role
                    });
                    var ro = Input.Role;
                    var userList = objecto._userManager.Users.Where(u => u.Email.Equals(Input.Email)).ToList();
                    if (userList.Count.Equals(0))
                    {
                        var user = new IdentityUser
                        {
                            UserName = Input.Nombre,
                            Email = Input.Email

                        };
                        var resul = await objecto._userManager.CreateAsync(user, Input.Password);// aqui se crea el usuarioo
                        if (resul.Succeeded)
                        {

                            await objecto._userManager.AddToRoleAsync(user, Input.Role); //agregar rol

                            var listUSer = objecto._userManager.Users.Where(x => x.Email.Equals(Input.Email)).ToList();// verrificar el ultimo 



                            var usuarios = new TUsuarios
                            {
                                Nombre = Input.Nombre,
                                Apellido = Input.Apellido,
                                
                                NID = Input.NID,
                                IdUser = listUSer[0].Id,//id usuerio
                            };

                            await objecto._context.AddAsync(usuarios);
                            objecto._context.SaveChanges();
                            valor = true;
                            return valor;


                        }
                        else
                        {

                            foreach (var item in resul.Errors)
                            {
                                Input = new InputModel
                                {
                                    ErrorMessage = item.Description,
                                    rolesLista = objecto._userRoles
                                };
                            }

                            valor = false;
                        }
                    }
                    else
                    {
                        Input = new InputModel
                        {
                            ErrorMessage = "El " + Input.Email + " ya esta registrado",
                            rolesLista = objecto._userRoles
                        };
                        valor = false;

                    }
                }
                else
                {
                    Input = new InputModel
                    {
                        ErrorMessage = "Seleccione un rol",
                        rolesLista = objecto._usersRole.getRoles(objecto._roleManger),
                    };
                }

                }
           
            catch (Exception e)
            {
                Input = new InputModel
                {
                    ErrorMessage = e.Message,
                    rolesLista = objecto._userRoles
                };
            }


            return valor;

        }


    } 
}