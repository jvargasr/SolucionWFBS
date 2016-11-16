using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WFBS.Negocio;

using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class PerfilesdeCargo
    {
        [TestMethod]
        public void crearPerfildeCargo()
        {

            WFBS.Negocio.PerfilesdeCargo pc = new WFBS.Negocio.PerfilesdeCargo();
            pc.descripcion = "Descripción de prueba";
            pc.Obsoleto = 0;

            List<WFBS.Negocio.Area> areas = new List<WFBS.Negocio.Area>();
            WFBS.Negocio.Area a = new WFBS.Negocio.Area();
            a.id_area = 1;
            areas.Add(a);

            bool esperando = true;
            bool actua = pc.Create(areas);

            Assert.AreEqual(esperando, actua);



        }

        [TestMethod]
        public void modificarArea()
        {

            WFBS.Negocio.PerfilesdeCargo pc = new WFBS.Negocio.PerfilesdeCargo();
            pc.Id_PC = 21;
            pc.descripcion = "Actualización de prueba";
            pc.Obsoleto = 0;

            List<WFBS.Negocio.Area> areas = new List<WFBS.Negocio.Area>();
            WFBS.Negocio.Area a = new WFBS.Negocio.Area();
            a.id_area = 2;
            areas.Add(a);


            bool esperando = true;
            bool actua = a.Update();

            Assert.AreEqual(esperando, actua);



        }

        [TestMethod]
        public void EliminarArea()
        {

            WFBS.Negocio.PerfilesdeCargo pc = new WFBS.Negocio.PerfilesdeCargo();

            pc.Id_PC = 22;

            bool esperando = true;
            bool actua = pc.Delete();

            Assert.AreEqual(esperando, actua);



        }


    }
}
