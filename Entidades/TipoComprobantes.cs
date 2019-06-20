using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class TipoComprobantes
    {

        [Key]

        public int IdTipoComprobante { get; set; }
        public string NombreComprobante { get; set; }

        public TipoComprobantes()
        {

            this.IdTipoComprobante = 0;
            this.NombreComprobante = string.Empty;

        }
    }
}
