using Microsoft.VisualStudio.TestTools.UnitTesting;
using TareaTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaTest.Entidades;

namespace TareaTest.BLL.Tests
{
    [TestClass()]
    public class DetalleVentasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<DetalleVentas> db = new Repositorio<DetalleVentas>();
            bool paso = false;
            DetalleVentas d = new DetalleVentas();

            d.IdDetalleVenta = 1;
            d.IdVenta = 1;
            d.IdProducto = 1;
            d.Unidades = 1;
            d.Costounidad = 123;
            d.DescuentoUnidad = 10;
            d.Total = 113;
            

            paso = db.Guardar(d);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<DetalleVentas> repositorio = new Repositorio<DetalleVentas>();
            bool paso = false;
            DetalleVentas d = repositorio.Buscar(1);
            d.Unidades = 2;
            d.Total = 468;
            paso = repositorio.Modificar(d);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<DetalleVentas> db = new Repositorio<DetalleVentas>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<DetalleVentas> db = new Repositorio<DetalleVentas>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<DetalleVentas> db = new Repositorio<DetalleVentas>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}