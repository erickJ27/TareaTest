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
    public class ModelosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Modelos> db = new Repositorio<Modelos> ();
            bool paso = false;
            Modelos m = new Modelos();

            m.IdModelo = 1;
            m.NombreModelo ="gddgf";
           

            paso = db.Guardar(m);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Modelos> repositorio = new Repositorio<Modelos>();
            bool paso = false;
            Modelos m = repositorio.Buscar(1);
            m.NombreModelo = "sdgf";
            paso = repositorio.Modificar(m);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Modelos> db = new Repositorio<Modelos>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Modelos> db = new Repositorio<Modelos>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Modelos> db = new Repositorio<Modelos>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}