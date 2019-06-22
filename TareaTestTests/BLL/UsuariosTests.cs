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
    public class UsuariosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Usuarios> db = new Repositorio<Usuarios> ();
            bool paso = false;
            Usuarios u = new Usuarios();
            u.IdUsuario = 1;
            u.IdEmpleado = 1;
            u.NombreUsuario = "sdfgs";
            u.Clave = "123";


            paso = db.Guardar(u);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            bool paso = false;
            Usuarios u = repositorio.Buscar(1);

            u.Clave = "1edg";
            paso = repositorio.Modificar(u);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Usuarios> db = new Repositorio<Usuarios>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Usuarios> db = new Repositorio<Usuarios>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Usuarios> db = new Repositorio<Usuarios>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}