using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Proveedores
    {
        [Key]
        public int IdProveedor { get; set; }
        public int IdPersona { get; set; }

        public Proveedores()
        {
            this.IdProveedor = 0;
            this.IdPersona = 0;

        }
    }
}
