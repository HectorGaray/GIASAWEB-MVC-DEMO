using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoGiasaWeb.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ProyectoGiasaWeb.Data;

namespace ProyectoGiasaWeb.Library
{
    public class LUsuarios: ListObject
    {
        //sobre carga 
        public LUsuarios()
        {

        }// sobre carga 
        public LUsuarios(RoleManager<IdentityRole> roleManager)
        {
            _roleManger = roleManager;
            _usersRole = new UsersRoles();
        } //Sobre carga de Roles
        public LUsuarios(UserManager<IdentityUser> userManager,// Sobre carga de Usuarios
            SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)// inicializacion de Objetos Para inicio de sesion
        {
            _userManager = userManager;
            _roleManger = roleManager;
            _signInManager = signInManager;
            _usersRole = new UsersRoles();
            _context = context;
        }
        internal async Task<List<object[]>>userLogin(string email,string password)
        {
            try
            {// coisidenciaa si 
                var result = await _signInManager.PasswordSignInAsync(email, password, false,
                    lockoutOnFailure: false); //cokies si se cierra el navegador false o true;
                if (result.Succeeded)// exitoso o no
                {
                    var appuser1 = _context.Users.Where(x => x.Email.Equals(email)).ToList();//aqui se guarda el usuario logiados 
                    var appuser2 = _context.TUsuarios.Where(x => x.IdUser.Equals(appuser1[0].Id)).ToList();//aqui se guarda el usuario logiados 
                    // consultar roles del sistema
                    //_userRoles = await _usersRole.getRole(_userManager, _roleManger, appuser1[0].Id);
                   /* _userData = new UserData //alamcenar todo
                    {
                        //Id = appuser[0].Id,
                        //Role = _userRoles[0].Text,
                        UserName = appuser2[0].Nombre + " " + appuser2[1].Apellido,
                       
                    };*/
                    code = "0";// nose Ingres correcramente
                    descripcion = result.Succeeded.ToString();
                   
                }
                else
                {
                    code = "1";// Error en Email o Pass
                    descripcion = "Email o contraseña invalidos";
                }
            }
            catch(Exception e)
            {
                code = "2";// Exepcion si existe algun error en Servidor
                descripcion = e.Message;
            }
            _identityError = new IdentityError // Pasar el Error por asp error User
            {
                Code = code,
                Description = descripcion
            };
            object[] data = { _identityError, _userData };// colleciones para datos 
            dataList.Add(data);// retornos de dato 

            return dataList;// Lista de objetos(error,roles,user,contex,objetos.list)
        }
      

        public String userData(HttpContext httpContext) // comprobar datos del usuario una vez logeado
        {
            String role = null;
            var user = httpContext.Session.GetString("User");

            if (user != null)
            {

                UserData dataItem = JsonConvert.DeserializeObject<UserData>(user.ToString());// COmponer los datos de String
                role = dataItem.Role;

            }
            else
            {
                role = "no data";
            }

            return role;
        }
    }
}
