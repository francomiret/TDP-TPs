using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio02.AccountManager.Domain;

namespace Ejercicio02.test.AccountManager.test.Domain.test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class DomainTests
    {
        [TestMethod]
        public void DocumentTest()
        {
            Document documento = new Document(DocumentType.DNI, "40404040");

            Assert.AreEqual(documento.Type, DocumentType.DNI);
            Assert.AreEqual(documento.Number, "40404040");

            documento.Type = DocumentType.CUIL;
            documento.Number = "00012101";

            Assert.AreEqual(documento.Type, DocumentType.CUIL);
            Assert.AreEqual(documento.Number, "00012101");
        }

        [TestMethod]
        public void AccountMovementTest()
        {
            DateTime now = DateTime.Now;
            AccountMovement movimiento = new AccountMovement(1, now, "Deposito", 5000.5);

            Assert.AreEqual(movimiento.Id, 1);
            Assert.AreEqual(movimiento.Date, now);
            Assert.AreEqual(movimiento.Description, "Deposito");
            Assert.AreEqual(movimiento.Amount, 5000.5);

            DateTime later = DateTime.Now;
            movimiento.Id = 2;
            movimiento.Date = later;
            movimiento.Description = "Retiro";
            movimiento.Amount = -200.56;

            Assert.AreEqual(movimiento.Id, 2);
            Assert.AreEqual(movimiento.Date, later);
            Assert.AreEqual(movimiento.Description, "Retiro");
            Assert.AreEqual(movimiento.Amount, -200.56);
        }

        [TestMethod]
        public void AccountTest()
        {
            Account cuenta = new Account(1, "Dolares", 5000);

            Assert.AreEqual(cuenta.Id, 1);
            Assert.AreEqual(cuenta.Name, "Dolares");
            Assert.AreEqual(cuenta.OverdraftLimit, 5000);

            AccountMovement movimiento1 = new AccountMovement(1, DateTime.Now, "Deposito", 200),
                            movimiento2 = new AccountMovement(2, DateTime.Now, "Retiro", -50),
                            movimiento3 = new AccountMovement(3, DateTime.Now, "Transferencia", -70);

            cuenta.Movements.Add(movimiento1);
            Assert.AreEqual(cuenta.GetBalance(), 200);

            cuenta.Movements.Add(movimiento2);
            Assert.AreEqual(cuenta.GetBalance(), 150);

            cuenta.Movements.Add(movimiento3);
            Assert.AreEqual(cuenta.GetBalance(), 80);
        }

        [TestMethod]
        public void ClientTest()
        {
            Document documento1 = new Document(DocumentType.DNI, "40404040");
            Client cliente = new Client(1, documento1, "Juan", "Perez");

            Assert.AreEqual(cliente.Id, 1);
            Assert.AreEqual(cliente.Document, documento1);
            Assert.AreEqual(cliente.FirstName, "Juan");
            Assert.AreEqual(cliente.LastName, "Perez");

            Document documento2 = new Document(DocumentType.CUIL, "00012101");
            cliente.Id = 2;
            cliente.Document = documento2;
            cliente.FirstName = "Raul";
            cliente.LastName = "Rodriguez";

            Assert.AreEqual(cliente.Id, 2);
            Assert.AreEqual(cliente.Document, documento2);
            Assert.AreEqual(cliente.FirstName, "Raul");
            Assert.AreEqual(cliente.LastName, "Rodriguez");

            Account cuenta1 = new Account(1, "Dolares", 5000),
                    cuenta2 = new Account(2, "Pesos", 60000),
                    cuenta3 = new Account(3, "Euros", 4000);

            cliente.Accounts.Add(cuenta1);
            cliente.Accounts.Add(cuenta2);
            cliente.Accounts.Add(cuenta3);

            Assert.AreEqual(cliente.Accounts[0], cuenta1);
            Assert.AreEqual(cliente.Accounts[1], cuenta2);
            Assert.AreEqual(cliente.Accounts[2], cuenta3);
        }
    }
}
