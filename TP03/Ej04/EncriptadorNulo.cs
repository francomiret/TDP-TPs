using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    /// <summary>
    /// Esta clase Correspnde al Encriptador Nulo
    /// </summary>
    public sealed class EncriptadorNulo : Encriptador
    {
        /// <summary>
        /// Este metodo crea una instancia de la clase EncriptadorNulo
        /// </summary>
        public EncriptadorNulo() : base("Null") { }

        /// <summary>
        /// Este metodo encripta una string utilizando el metodo Nulo
        /// </summary>
        /// <param name="pCadena"> Corresponde a la String que contiene la cadena a encriptar</param>
        /// <returns></returns> Devuelve la cadena encriptada
        public override string Encriptar(string pCadena)
        {
            return pCadena;
        }

        /// <summary>
        /// Este metodo desencripta una string utilizando el metodo Nulo
        /// </summary>
        /// <param name="pCadena"> Corresponde a la String que contiene la cadena a desencriptar</param>
        /// <returns></returns> Devuelve la cadena desencriptada
        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        }
    }
}
