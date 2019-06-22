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
    public class EmpleadosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Empleados> db = new Repositorio<Empleados>();
            bool paso = false;
            Empleados e = new Empleados();

            e.IdEmpleado = 1;
            e.IdEstado = 1;
            e.IdCargo = 1;
            e.IdPersona = 1;

            paso = db.Guardar(e);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Empleados> repositorio = new Repositorio<Empleados>();
            bool paso = false;
            Empleados e = repositorio.Buscar(1);
            e.IdPersona = 2;
            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Empleados> db = new Repositorio<Empleados>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Empleados> db = new Repositorio<Empleados>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Empleados> db = new Repositorio<Empleados>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}