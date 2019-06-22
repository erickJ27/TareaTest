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
    public class VentasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Ventas> db = new Repositorio<Ventas> ();
            bool paso = false;
            Ventas v = new Ventas();

            v.IdVenta = 1;
            v.IdUsuario = 1;
            v.IdCliente = 1;
            v.IdTipoComprobante = 1;
            v.FechaVenta = DateTime.Now;
            v.Igv = 1;
            v.SubTotal = 1;
            v.CostoVenta = 1;

            paso = db.Guardar(v);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Ventas> repositorio = new Repositorio<Ventas>();
            bool paso = false;
            Ventas v = repositorio.Buscar(1);

            v.IdCliente = 2;


            paso = repositorio.Modificar(v);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Ventas> db = new Repositorio<Ventas>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Ventas> db = new Repositorio<Ventas>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Ventas> db = new Repositorio<Ventas>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}