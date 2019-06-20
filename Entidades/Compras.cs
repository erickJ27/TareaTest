using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
   public class Compras
    {

        [Key]
        public int IdCompra { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCompra { get; set; }
        public int IdProveedor { get; set; }
        public int IdTipoComprobante { get; set; }
        public double CostoComprobante { get; set; }
      

        public Compras()
        {
            IdCompra = 0;
            IdUsuario = 0;
            FechaCompra = DateTime.Now;
            IdProveedor = 0;
            IdTipoComprobante = 0;
            CostoComprobante = 0;
            

        }
    }
}
