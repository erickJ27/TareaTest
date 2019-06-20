using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
   public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }

        public Clientes()
        {
            IdCliente = 0;
            Nombre = string.Empty;
        }
    }
}
