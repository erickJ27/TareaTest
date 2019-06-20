using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
  public  class Cargos
    {
        [Key]
        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public int IdEstado { get; set; }

        public Cargos()
        {
            IdCargo = 0;
            NombreCargo = string.Empty;
            IdEstado = 0;

        }
    }
}
