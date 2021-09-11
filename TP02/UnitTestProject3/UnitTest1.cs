using System;
using Ejercicio03Nuevo;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject3
{
    [TestClass]
    public class UnitTeste1
    {
        [TestMethod]
        public void TestMethod1()
        {
            char letra = 'a';
            
            Palabra pal = new Palabra("casa");
           

            string palabra = pal.LetraEnPalabra(letra);

            Assert.AreEqual("*a*a",palabra);

        }
    }
}
