using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WFBS.Negocio;

namespace PruebasUnitarias
{
    [TestClass]
    public class Area
    {
        [TestMethod]
        public void crearArea()
        {

            WFBS.Negocio.Area a = new WFBS.Negocio.Area();

            a.id_area = 6;
            a.area = "prueba6";
            a.abreviacion = "p6";
            a.obsoleta = 0;

            bool esperando = true;
            bool actua = a.Create();

            Assert.AreEqual(esperando, actua);



        }

        [TestMethod]
        public void modificarArea()
        {

            WFBS.Negocio.Area a = new WFBS.Negocio.Area();

            a.id_area = 3;
            
               a.area = "ppppppp";
                a.abreviacion = "p67";
                a.obsoleta = 0;
            

            bool esperando = true;
            bool actua = a.Update();

            Assert.AreEqual(esperando, actua);



        }

        [TestMethod]
        public void EliminarArea()
        {

            WFBS.Negocio.Area a = new WFBS.Negocio.Area();

            a.Id_area = 1;

            bool esperando = true;
            bool actua = a.Delete();

            Assert.AreEqual(esperando, actua);



        }


    }
}
