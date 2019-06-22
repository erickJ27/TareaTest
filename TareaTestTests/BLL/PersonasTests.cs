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
    public class PersonasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Personas> db = new Repositorio<Personas>();
            Personas personas = new Personas();
            personas.PersonaId = 2;
            personas.Dni = 1;
            personas.Nombre = "cgdfdh";
            personas.Materno = "cv";
            personas.Paterno = "fhdgghd";
            personas.FechaNacimiento = DateTime.Now;
            personas.Telefono = 123456;
            personas.Correo = "fdgfd@gmail.com";
            personas.Sexo = "M";
            personas.IdImagen = 1;
            personas.Direccion = "dfgdgfdgh";
            personas.IdTipoPersona = 1;

            Repositorio<Personas> repositorio = new Repositorio<Personas>();

            bool paso = false;

            paso = repositorio.Guardar(personas);

            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Personas> repositorio = new Repositorio<Personas>();
            bool paso = false;
            Personas p = repositorio.Buscar(2);
            p.Nombre = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Personas> db = new Repositorio<Personas>();
            Assert.IsNotNull(db.Buscar(2));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Personas> db = new Repositorio<Personas>();
            Assert.IsNotNull(db.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Personas> db = new Repositorio<Personas>();
            Assert.IsTrue(db.Eliminar(2));

        }
    }
}