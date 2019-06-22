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
    public class UnidadMedidasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<UnidadMedidas> db = new Repositorio<UnidadMedidas> ();
            bool paso = false;
            UnidadMedidas um = new UnidadMedidas();

            um.IdUnidadMedida = 1;
            um.NombreUnidad = "dfghdf";

            paso = db.Guardar(um);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]

        public void ModificarTest()
        {
            Repositorio<UnidadMedidas> repositorio = new Repositorio<UnidadMedidas>();
            bool paso = false;
            UnidadMedidas um = repositorio.Buscar(1);
            um.NombreUnidad = "adda";

            paso = repositorio.Modificar(um);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<UnidadMedidas> db = new Repositorio<UnidadMedidas>();
            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<UnidadMedidas> db = new Repositorio<UnidadMedidas>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<UnidadMedidas> db = new Repositorio<UnidadMedidas>();
            Assert.IsTrue(db.Eliminar(1));

        }
    }
}