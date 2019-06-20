using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Personas
    {

        [Key]
        public int PersonaId { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Materno { get; set; }
        public string Paterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public int IdImagen { get; set; }
        public string Direccion { get; set; }
        public int IdTipoPersona { get; set; }

        public Personas()
        {
            this.PersonaId = 0;
            this.Dni = 0;
            this.Nombre = string.Empty;
            this.Materno = string.Empty;
            this.Paterno = string.Empty;
            this.FechaNacimiento = DateTime.Now;
            this.Telefono = 0;
            this.Correo = string.Empty;
            this.Sexo = string.Empty;
            this.IdImagen = 0;
            this.Direccion = string.Empty; ;
            this.IdTipoPersona = 0;

        }
    }
}
