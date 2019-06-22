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
    public class ImagenesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Imagenes> db = new Repositorio<Imagenes>();
            bool paso = false;
            Imagenes i= new Imagenes();

            i.IdImagen = 1;
            i.RutaImagen = "dfgfgf";

            paso = db.Guardar(i);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Imagenes> repositorio = new Repositorio<Imagenes>();
            bool paso = false;
            Imagenes i = repositorio.Buscar(1);
            i.RutaImagen = "sd";
            paso = repositorio.Modificar(i);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Imagenes> db = new Repositorio<Imagenes>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Imagenes> db = new Repositorio<Imagenes>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Imagenes> db = new Repositorio<Imagenes>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}