using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    /// <summary>
    /// Esta clase Corresponde al Encriptador espejo
    /// </summary>
    public class EncriptadorEspejo : Encriptador
    {
        /// <summary>
        /// Este metodo crea una instancia de la clase EncriptadorEspejo
        /// </summary>
        public EncriptadorEspejo() : base("Espejo") { }

        /// <summary>
        /// Este metodo encripta una cadena utilizando el metodo espejo
        /// </summary>
        /// <param name="pCadena"></param>
        /// <returns></returns>
        public override string Encriptar(string pCadena)
        {
            char[] anedac = pCadena.ToCharArray();
            Array.Reverse(anedac);
            string[] anedaC = (new String(anedac)).Split(' ');
            Array.Reverse(anedaC);
            return String.Join(" ", anedaC);
        }

        /// <summary>
        /// Este metodo Desencripta una cadena utilizando el metodo espejo
        /// </summary>
        /// <param name="pCadena"></param> corresponde a la cadena a desencriptar
        /// <returns></returns> Devuelve la cadena desencriptada
        public override string Desencriptar(string pCadena)
        {
            return this.Encriptar(pCadena);
        }
    }
}
