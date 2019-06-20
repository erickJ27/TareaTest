using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }

        public Usuarios()
        {
            this.IdUsuario = 0;
            this.IdEmpleado = 0;
            this.NombreUsuario = string.Empty;
            this.Clave = string.Empty;

        }
    }
}
