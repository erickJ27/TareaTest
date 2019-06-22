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
    public class MarcasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Marcas> db = new Repositorio<Marcas>();
            bool paso = false;
            Marcas m = new Marcas();

            m.IdMarca = 1;
            m.NombreMarca = "fdg";

            paso = db.Guardar(m);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Marcas> repositorio = new Repositorio<Marcas>();
            bool paso = false;
            Marcas m = repositorio.Buscar(1);
            m.NombreMarca = "fgdfg";
            paso = repositorio.Modificar(m);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Marcas> db = new Repositorio<Marcas>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Marcas> db = new Repositorio<Marcas>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Marcas> db = new Repositorio<Marcas>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}