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
    public class ProveedoresTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Proveedores> db = new Repositorio<Proveedores> ();
            bool paso = false;
            Proveedores p = new Proveedores();
            p.IdProveedor = 1;
            p.IdPersona = 1;
            

            paso = db.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Proveedores> repositorio = new Repositorio<Proveedores>();
            bool paso = false;
            Proveedores p = repositorio.Buscar(1);

            p.IdPersona = 2;


            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Proveedores> db = new Repositorio<Proveedores>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Proveedores> db = new Repositorio<Proveedores>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Proveedores> db = new Repositorio<Proveedores>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}