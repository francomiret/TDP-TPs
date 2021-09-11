using System;
using Ejercicio01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarioEj1
{
    [TestClass]
    public class UnitTest1
    {
       [TestMethod]
        public void TestDistancia()
        {
            Punto p1 = new Punto(0, 0);
            Punto p2 = new Punto(1, 1);
            double distancia = p1.CalcularDistanciaDesde(p2);
            Assert.AreEqual(1, distancia);
            
        }

        [TestMethod]
        public void Area()
        {
            Punto p3 = new Punto(0, 0);
            Circulo circ = new Circulo(p3, 4);
            double area = circ.Area();
            Assert.AreEqual(6, area);
        
        }

    }
}
