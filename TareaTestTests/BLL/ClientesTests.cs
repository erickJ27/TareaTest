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
    public class ClientesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();
            Clientes clientes = new Clientes();

            clientes.IdCliente = 1;
            clientes.Nombre = "efgdgf";
            bool paso = false;

            paso = db.Guardar(clientes);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Clientes> repositorio = new Repositorio<Clientes>();
            bool paso = false;
            Clientes c = repositorio.Buscar(1);
            c.Nombre = "asda";
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}