using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoGiasaWeb.Areas.Usuarios.Models
{
    public class InputModelRegistrar
    {
        [Required(ErrorMessage = "<font color='red'>Campo Nombre Obligatorio</font>")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "<font color='red'>Campo Apellido</font>")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "<font color='red'>NID Obligatorio</font>")]
        public string NID { get; set; }
        [Required(ErrorMessage = "<font color='red'>Email Obligatorio</font>")]
        [EmailAddress(ErrorMessage = "<font color='red'>Los datos ingresados no es un Email valido</font>")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "<font color='red'>Contraseña Obligatorio</font>")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "<font color='red'>El numero de caracteres {0} debe ser al menos {2}.</font>", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
