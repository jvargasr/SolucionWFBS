using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WFBS.Negocio;

namespace PruebasUnitarias
{
    [TestClass]
    public class Usuario
    {
        [TestMethod]
        public void crearUsuario()
        {

            WFBS.Negocio.Usuario a = new WFBS.Negocio.Usuario();
            a.Rut = "5555555-5";
            a.Id_Perfil = 2;
            a.Id_Area = 3;
            a.Nombre = "miguel";
            a.Sexo = "M";
            a.Jefe = null;
            a.Password = "1111111";
            a.Obsoleto = 0;

            bool esperando = true;
            bool actua = a.Create();

            Assert.AreEqual(esperando, actua);



        }

        [TestMethod]
        public void modificarUsuario()
        {

            WFBS.Negocio.Usuario a = new WFBS.Negocio.Usuario();
            a.Rut = "5555555-5";
            a.Id_Perfil = 2;
            a.Id_Area = 3;
            a.Nombre = "miguel";
            a.Sexo = "M";
            a.Jefe = null;
            a.Password = "1111111";
            a.Obsoleto = 1;


            bool esperando = true;
            bool actua = a.Update();

            Assert.AreEqual(esperando, actua);



        }

        [TestMethod]
        public void EliminarUsuario()
        {

            WFBS.Negocio.Usuario a = new WFBS.Negocio.Usuario();
            a.Rut = "18661447-k";

            bool esperando = true;
            bool actua = a.Delete();

            Assert.AreEqual(esperando, actua);



        }

    }
}
