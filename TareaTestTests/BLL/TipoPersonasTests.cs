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
    public class TipoPersonasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<TipoPersonas> db = new Repositorio<TipoPersonas> ();
            bool paso = false;
            TipoPersonas tp = new TipoPersonas();

            tp.IdTipoPersona = 1;
            tp.Nombre = "dfgf";
            
            paso = db.Guardar(tp);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<TipoPersonas> repositorio = new Repositorio<TipoPersonas>();
            bool paso = false;
            TipoPersonas tp = repositorio.Buscar(1);
            tp.Nombre = "dasda";

            paso = repositorio.Modificar(tp);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<TipoPersonas> db = new Repositorio<TipoPersonas>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<TipoPersonas> db = new Repositorio<TipoPersonas>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<TipoPersonas> db = new Repositorio<TipoPersonas>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}