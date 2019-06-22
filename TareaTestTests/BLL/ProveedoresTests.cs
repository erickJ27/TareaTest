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
    public class TipoComprobantesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<TipoComprobantes> db = new Repositorio<TipoComprobantes> ();
            bool paso = false;
            TipoComprobantes tc = new TipoComprobantes();

            tc.IdTipoComprobante = 1;
            tc.NombreComprobante = "dfgdg";

            paso = db.Guardar(tc);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<TipoComprobantes> repositorio = new Repositorio<TipoComprobantes>();
            bool paso = false;
            TipoComprobantes tc = repositorio.Buscar(1);


            tc.NombreComprobante = "daa";

            paso = repositorio.Modificar(tc);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<TipoComprobantes> db = new Repositorio<TipoComprobantes>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<TipoComprobantes> db = new Repositorio<TipoComprobantes>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<TipoComprobantes> db = new Repositorio<TipoComprobantes>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}