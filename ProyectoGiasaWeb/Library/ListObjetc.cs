using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoGiasaWeb.Data;
using ProyectoGiasaWeb.Models;

namespace ProyectoGiasaWeb.Library
{
    // Lista de Objetos para el uso de Usuarios Y Roles nota: ListObject ya existe->List
    public class ListObject
    {
        public String descripcion, code;// Auxiliares 


        public UsersRoles _usersRole;// library
        public UserData _userData;//model
        public IdentityError _identityError;// Clase De asp para Erros
        public ApplicationDbContext _context;// Contexto de la base de datos SQL
        public LUsuarios _usuarios;

        public List<SelectListItem> _userRoles;// Lista de Roles: data: User O Admin

        public RoleManager<IdentityRole> _roleManger;// manejador clase de asp rol
        public UserManager<IdentityUser> _userManager;// manejador clase de asp user
        public SignInManager<IdentityUser> _signInManager;// manejador inicio de sesion sap

        public List<object[]> dataList = new List<object[]>(); // Lista de Objetos anteriores
    }
}
