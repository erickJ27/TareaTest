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
    public class EstadosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Estados> db = new Repositorio<Estados>();
            bool paso = false;
            Estados e = new Estados();

            e.IdEstado = 1;
            e.FechaInicio = DateTime.Now;
            e.FechaFin = DateTime.Today;
            e.Estado = "fgfd";

            paso = db.Guardar(e);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Estados> repositorio = new Repositorio<Estados>();
            bool paso = false;
            Estados e = repositorio.Buscar(1);
            e.Estado = "fgdg";
            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Estados> db = new Repositorio<Estados>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Estados> db = new Repositorio<Estados>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Estados> db = new Repositorio<Estados>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}