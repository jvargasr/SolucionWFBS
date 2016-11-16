﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WFBS.Negocio;

namespace PruebasUnitarias
{
    [TestClass]
    public class Habilidades
    {
        [TestMethod]
        public void crearHabilidad()
        {

            WFBS.Negocio.Habilidad a = new WFBS.Negocio.Habilidad();

            a.Id_Competencia = 1;
            a.Id_Habilidad = 2;
            a.Nombre = "aaaaaa";
            a.Orden_Asignado = 3;
            a.Alternativa_Pregunta = "¿lololo?";

            bool esperando = true;
            bool actua = a.Create();

            Assert.AreEqual(esperando, actua);



        }

        [TestMethod]
        public void modificarHabilidad()
        {

            WFBS.Negocio.Habilidad a = new WFBS.Negocio.Habilidad();

            a.Id_Competencia = 1;
            a.Id_Habilidad = 1;
            a.Nombre = "palala";
            a.Orden_Asignado = 3;
            a.Alternativa_Pregunta = "¿pololo?";

    
            bool esperando = true;
            bool actua = a.Update();

            Assert.AreEqual(esperando, actua);



        }

        [TestMethod]
        public void EliminarHabilidad()
        {

            WFBS.Negocio.Habilidad a = new WFBS.Negocio.Habilidad();

            a.Id_Habilidad = 2;

            bool esperando = true;
            bool actua = a.Delete();

            Assert.AreEqual(esperando, actua);



        }

    }
}
