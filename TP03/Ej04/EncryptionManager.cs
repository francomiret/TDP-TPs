using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    /// <summary>
    /// Esta clase provee los metodos para encriptar y desencriptar, con diferentes encriptadores
    /// </summary>
    public sealed class EncryptionManager
    {
        private static EncryptionManager iInstancia = null;
        private EncryptionManager() { } 
        public static EncryptionManager Instancia
        {
            get 
            {
                if (iInstancia == null) iInstancia = new EncryptionManager();
                return iInstancia;
            }
        }
        private FabricaEncriptadores iFabrica = FabricaEncriptadores.Instancia;

        /// <summary>
        /// Este metodo se utiliza para encriptar una cadena con un determinado encriptador
        /// </summary>
        /// <param name="pCadena"></param> Corresponde a la cadena a encriptar
        /// <param name="pEncriptador"></param> Corresponde al encriptador a utilizar
        /// <returns></returns> Devuelve la cadena encriptada
        public string Encriptar(string pCadena, string pEncriptador)
        {
            return iFabrica.GetEncriptador(pEncriptador).Encriptar(pCadena);
        }

        /// <summary>
        /// Este metodo se utiliza para desencriptar una cadena con un determinado encriptador
        /// </summary>
        /// <param name="pCadena"></param> Corresponde a la cadena a desencriptar
        /// <param name="pEncriptador"></param> Corresponde al encriptador a utilizar
        /// <returns></returns> Devuelve la cadena desencriptada
        public string Desencriptar(string pCadena, string pEncriptador)
        {
            return iFabrica.GetEncriptador(pEncriptador).Desencriptar(pCadena);
        }
    }
}
