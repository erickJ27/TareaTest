using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class DetalleVentas
    {
        [Key]
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public double Unidades { get; set; }
        public double Costounidad { get; set; }
        public double DescuentoUnidad { get; set; }
        public double Total { get; set; }

        public DetalleVentas()
        {
            IdDetalleVenta = 0;
            IdVenta = 0;
            IdProducto = 0;
            Unidades = 0;
            Costounidad = 0;
            DescuentoUnidad = 0;
            Total = 0;

        }
    }
}
