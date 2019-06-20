using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTest.Entidades
{
    public class Ventas
    {
        [Key]
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoComprobante { get; set; }
        public DateTime FechaVenta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Igv { get; set; }
        public double SubTotal { get; set; }
        public double CostoVenta { get; set; }

        public Ventas()
        {
            this.IdVenta = 0;
            this.IdUsuario = 0;
            this.IdCliente = 0;
            this.IdTipoComprobante = 0;
            this.FechaVenta = DateTime.Now;
            this.FechaNacimiento = DateTime.Now;
            this.Igv = 0;
            this.SubTotal = 0;
            this.CostoVenta = 0;

        }


    }
}
