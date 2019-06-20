using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
   public class UnidadMedidas
    {
        [Key]
        public int IdUnidadMedida { get; set; }
        public string NombreUnidad { get; set; }

        public UnidadMedidas()
        {
            this.IdUnidadMedida = 0;
            this.NombreUnidad = string.Empty;

        }
    }
}
