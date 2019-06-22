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
    public class PermisosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Permisos> db = new Repositorio<Permisos> ();
            bool paso = false;
            Permisos p= new Permisos();

            p.IdPermiso = 1;
            p.Descripcion = "fgedfg";
            p.Funcionalidad = "dfg";

            paso = db.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Permisos> repositorio = new Repositorio<Permisos>();
            bool paso = false;
            Permisos p = repositorio.Buscar(1);
            p.Descripcion = "adw";

            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Permisos> db = new Repositorio<Permisos>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Permisos> db = new Repositorio<Permisos>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Permisos> db = new Repositorio<Permisos>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}