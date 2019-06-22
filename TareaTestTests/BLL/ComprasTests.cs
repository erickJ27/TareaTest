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
    public class ComprasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Compras> db = new Repositorio<Compras>();
            Compras compras = new Compras();

            compras.IdCompra = 1;
            compras.IdUsuario = 1;
            compras.FechaCompra = DateTime.Now;
            compras.IdProveedor = 1;
            compras.IdTipoComprobante = 1;
            compras.CostoComprobante = 123;

            bool paso = false;

            paso = db.Guardar(compras);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Compras> repositorio = new Repositorio<Compras>();
            bool paso = false;
            Compras c = repositorio.Buscar(1);
            c.CostoComprobante= 32234;
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Compras> db = new Repositorio<Compras>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Compras> db = new Repositorio<Compras>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Compras> db = new Repositorio<Compras>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}