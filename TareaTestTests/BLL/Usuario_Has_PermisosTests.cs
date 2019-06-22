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
    public class Usuario_Has_PermisosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Usuario_Has_Permisos> db = new Repositorio<Usuario_Has_Permisos> ();
            bool paso = false;
            Usuario_Has_Permisos u = new Usuario_Has_Permisos();

            u.IdUsuario = 1;
            u.IdPermiso = 1;

            paso = db.Guardar(u);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Usuario_Has_Permisos> repositorio = new Repositorio<Usuario_Has_Permisos>();
            bool paso = false;
            Usuario_Has_Permisos u = repositorio.Buscar(1);

            u.IdPermiso = 2;
            paso = repositorio.Modificar(u);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Usuario_Has_Permisos> db = new Repositorio<Usuario_Has_Permisos>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Usuario_Has_Permisos> db = new Repositorio<Usuario_Has_Permisos>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Usuario_Has_Permisos> db = new Repositorio<Usuario_Has_Permisos>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}