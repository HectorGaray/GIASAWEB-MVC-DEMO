using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoGiasaWeb.Models
{
    public class LoginViewModels
    {
        [BindProperty]
        public InputModel input { get; set; } //acceder a clases de abajo

        [TempData] // elimna los datos de clase contructor
        public string ErroMessage { get; set; }


        public class InputModel
        {
            [Required(ErrorMessage = "<font color=red>El campo Email es obligatorio</font>")]
            [EmailAddress(ErrorMessage = "<font color=red>Email no valido</font>")]
            public string Email { get; set; }

            [Required(ErrorMessage = "<font color=red>El campo Contraseña es obligatorio</font>")]
            [DataType(DataType.Password)]
            public string Password { get; set; }


        }
    }
}
