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
    public class ProductosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Productos> db = new Repositorio<Productos> ();
            bool paso = false;
            Productos p = new Productos();

            p.IdProducto = 1;
            p.Nombre = "sdfgd";
            p.Descripcion = "esrdg";
            p.FechaFabricacion = DateTime.Now;
            p.CostoCompra = 23442;
            p.Stock = 10;
            p.IdUnidadMedida = 1;
            p.IdImagen = 1;
            p.IdCategoria = 1;
            p.IdMarca = 1;
            p.IdModelo = 1;

            paso = db.Guardar(p);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            bool paso = false;
            Productos p = repositorio.Buscar(1);

            p.Nombre = "asda";
            p.Descripcion = "das";

            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Productos> db = new Repositorio<Productos>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Productos> db = new Repositorio<Productos>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Productos> db = new Repositorio<Productos>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}