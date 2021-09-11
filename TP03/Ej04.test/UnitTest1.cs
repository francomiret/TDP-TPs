using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ej04.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_EncriptadorAES()
        {
            IEncriptador encriptador = new EncriptadorAES();
            string original = "Esta es mi casa",
                   encriptado = encriptador.Encriptar(original);
            bool encOk = encriptado == "zjtnjDQnfb6s+6UzxjsS2w==",
                 desOk = encriptador.Desencriptar(encriptado) == original;

            Assert.IsTrue(encOk && desOk);
        }
        [TestMethod]
        public void Test_EncriptadorCesar()
        {
            IEncriptador encriptador = new EncriptadorCesar(3);
            string original = "Esta es mi casa",
                   encriptado = encriptador.Encriptar(original);
            bool encOk = encriptado == "Hvwd hv pl fdvd",
                 desOk = encriptador.Desencriptar(encriptado) == original;

            Assert.IsTrue(encOk && desOk);
        }
        [TestMethod]
        public void Test_EncriptadorMix()
        {
            IEncriptador encriptador = new EncriptadorMix();
            string original = "Esta es mi casa",
                   encriptado = encriptador.Encriptar(original);
            bool encOk = encriptado == "asaa em si ctsE",
                 desOk = encriptador.Desencriptar(encriptado) == original;

            Assert.IsTrue(encOk && desOk);
        }
        [TestMethod]
        public void Test_EncriptadorEspejo()
        {
            IEncriptador encriptador = new EncriptadorEspejo();
            string original = "Esta es mi casa",
                   encriptado = encriptador.Encriptar(original);
            bool encOk = encriptado == "atsE se im asac",
                 desOk = encriptador.Desencriptar(encriptado) == original;

            Assert.IsTrue(encOk && desOk);
        }
        [TestMethod]
        public void Test_EncriptadorNulo()
        {
            IEncriptador encriptador = new EncriptadorNulo();
            string original = "Esta es mi casa",
                   encriptado = encriptador.Encriptar(original);
            bool encOk = encriptado == "Esta es mi casa",
                 desOk = encriptador.Desencriptar(encriptado) == original;

            Assert.IsTrue(encOk && desOk);
        }
        [TestMethod]
        public void Test_FabricaEncriptadores()
        {
            FabricaEncriptadores iFabrica = FabricaEncriptadores.Instancia;

            bool cesarOk = iFabrica.GetEncriptador("cesar").ToString() == (new EncriptadorCesar(3)).ToString(),
                aesOk = iFabrica.GetEncriptador("aes").ToString() == (new EncriptadorAES()).ToString(),
                mixOk = iFabrica.GetEncriptador("mix").ToString() == (new EncriptadorMix()).ToString(),
                espejoOk = iFabrica.GetEncriptador("espejo").ToString() == (new EncriptadorEspejo()).ToString(),
                nuloOk = iFabrica.GetEncriptador("cualquier texto").ToString() == (new EncriptadorNulo()).ToString();

            Assert.IsTrue(cesarOk && aesOk && mixOk && espejoOk && nuloOk);
        }
        [TestMethod]
        public void Test_EncryptionManager_Encriptar()
        {
            EncryptionManager iManager = EncryptionManager.Instancia;
            string original = "Esta es mi casa";

            bool cesarOk = iManager.Encriptar(original, "cesar") == "Hvwd hv pl fdvd",
                aesOk = iManager.Encriptar(original, "aes") == "zjtnjDQnfb6s+6UzxjsS2w==",
                mixOk = iManager.Encriptar(original, "mix") == "asaa em si ctsE",
                espejoOk = iManager.Encriptar(original, "espejo") == "atsE se im asac",
                nuloOk = iManager.Encriptar(original, "cualquier texto") == "Esta es mi casa";

            Assert.IsTrue(cesarOk && aesOk && mixOk && espejoOk && nuloOk);
        }
        [TestMethod]
        public void Test_EncryptionManager_Desencriptar()
        {
            EncryptionManager iManager = EncryptionManager.Instancia;
            string original = "Esta es mi casa";

            bool cesarOk = iManager.Desencriptar("Hvwd hv pl fdvd", "cesar") == original,
                aesOk = iManager.Desencriptar("zjtnjDQnfb6s+6UzxjsS2w==", "aes") == original,
                mixOk = iManager.Desencriptar("asaa em si ctsE", "mix") == original,
                espejoOk = iManager.Desencriptar("atsE se im asac", "espejo") == original,
                nuloOk = iManager.Desencriptar("Esta es mi casa", "cualquier texto") == original;

            Assert.IsTrue(cesarOk && aesOk && mixOk && espejoOk && nuloOk);
        }
    }
}
