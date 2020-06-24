using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoLogin.Models
{
    public class Usuarios
    {
        [Key]
        public int usuarioId { get; set; }

        [Required(ErrorMessage = "Debe de introducir el nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Debe de introducir la contraseña")]
        public string contraseña { get; set; }

        [Required(ErrorMessage = "Debe de introducir el correo electronico")]
        public string correoElectronico { get; set; }  
    }
}
