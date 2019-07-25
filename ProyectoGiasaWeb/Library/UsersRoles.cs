using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoGiasaWeb.Library
{
    public class UsersRoles : ListObject // Herencia ListObjetc para poder usar la Insession en Cascada
    {
        public UsersRoles()
        {
            _userRoles = new List<SelectListItem>();

        }
        //metodo para consultar rol de usuario usando ID usuario
        public async Task<List<SelectListItem>> getRole(UserManager<IdentityUser> userManager, 
            RoleManager<IdentityRole> roleManager, string ID)
        {
            var users = await userManager.FindByIdAsync(ID);
            var roles = await userManager.GetRolesAsync(users);
            if (roles.Count.Equals(0))// este usuario no tien rol
            {
                _userRoles.Add(new SelectListItem {
                    Value="0",
                    Text="No role"
                });

            }
            else
            {
                var roleUser = roleManager.Roles.Where(m => m.Name.Equals(roles[0]));
                foreach( var Data in roleUser)
                {
                    _userRoles.Add(new SelectListItem
                    {
                        Value = Data.Id,
                        Text = Data.Name
                    });
                }
            }


            return _userRoles;
        }// Obetener rol, ID consultas  IDENTITY

   public List<SelectListItem> getRoles(RoleManager<IdentityRole> roleManager)// obtener todos los roles desde db para el combo 
        {
            var role = roleManager.Roles.ToList();// roles de lista 
            role.ForEach(item =>
            {
                _userRoles.Add(new SelectListItem
                {
                    Value = item.Id,// aqui se guarda el id
                    Text = item.Name// nombre que se disco

                });
            });
            return _userRoles;
        }


    }
}
