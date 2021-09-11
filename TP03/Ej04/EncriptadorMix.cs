using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    /// <summary>
    /// Esta clase corresponde al encriptador Mix
    /// </summary>
    public class EncriptadorMix : Encriptador
    {
        /// <summary>
        /// Este metodo crea una instancia de la clase EncriptadorMix
        /// </summary>
        public EncriptadorMix() : base("Mix") { }

        /// <summary>
        /// Este metodo encripta una string utilizando el metodo Mix
        /// </summary>
        /// <param name="pCadena">corresponde a la String que contiene la cadena a encriptar</param>
        /// <returns></returns> Devuelve la cadena encriptada
        public override string Encriptar(string pCadena)
        {
            int longitudDeCadena = pCadena.Length;
            double tope = longitudDeCadena / 2;
            char[] pChars = pCadena.ToCharArray();
            for (int i = 0; i < Math.Floor(tope); i += 2)
            {
                char aux = pChars[i];
                pChars[i] = pChars[longitudDeCadena - 1 - i];
                pChars[longitudDeCadena - 1 - i] = aux;
            }
            return new String(pChars);
        }
        /// <summary>
        /// Este metodo desencripta una string utilizando el metodo Mix
        /// </summary>
        /// <param name="pCadena">Corresponde a la String que contiene la cadena a desencriptar</param>
        /// <returns></returns> Devuelve la cadena desencriptada
        public override string Desencriptar(string pCadena)
        {
            return this.Encriptar(pCadena);
        }
    }
}
