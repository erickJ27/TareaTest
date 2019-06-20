using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaTest.Entidades;

namespace TareaTest.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Cargos> Cargo { get; set; }
        public DbSet<Categorias> Categoria { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Compras> Compra { get; set; }
        public DbSet<DetalleCompras> DetalleCompra { get; set; }
        public DbSet<DetalleVentas> Detalleventa { get; set; }
        public DbSet<Empleados> Empleado { get; set; }
        public DbSet<Estados> Estado { get; set; }
        public DbSet<Imagenes> Imagen { get; set; }
        public DbSet<Marcas> Marca { get; set; }
        public DbSet<Modelos> Modelo { get; set; }
        public DbSet<Permisos> Permiso { get; set; }
        public DbSet<Personas> Persona { get; set; }
        public DbSet<Productos> Producto { get; set; }
        public DbSet<Proveedores> Proveedor { get; set; }
        public DbSet<TipoComprobantes> Tipocomprobante { get; set; }
        public DbSet<UnidadMedidas> UnidadMedida { get; set; }
        public DbSet<TipoPersonas> Tipopersona { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Ventas> Venta{ get; set; }
        public DbSet<Usuario_Has_Permisos> Usuario_Has_Pdermiso { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
