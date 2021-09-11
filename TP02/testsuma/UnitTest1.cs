using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio04;

namespace testsuma
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             Complejo a = new Complejo(2, 4);
             Complejo b = new Complejo(1, 1);
            // Complejo c = new Complejo(3, 5);
             double res = a.Sumar(b).Real;
            // double cres = c.Real;
            Assert.AreEqual(3, res);
        }
    }
}
