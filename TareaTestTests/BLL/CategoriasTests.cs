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
    public class CategoriasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Categorias> db = new Repositorio<Categorias>();
            Categorias categorias = new Categorias();

            categorias.IdCategoria = 1;
            categorias.NombreCategoria = "fgfgf";
            categorias.Descripcion = "egrgdg";
            bool paso = false;

            paso = db.Guardar(categorias);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<Categorias> repositorio = new Repositorio<Categorias>();
            bool paso = false;
           Categorias c = repositorio.Buscar(1);
            c.NombreCategoria = "fdhdfgd";
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Categorias> db = new Repositorio<Categorias>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Cargos> db = new Repositorio<Cargos>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Categorias> db = new Repositorio<Categorias>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}