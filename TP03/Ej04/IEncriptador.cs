using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    /// <summary>
    /// Esta es una clase interfaz de la clase encriptador
    /// </summary>
    public abstract class IEncriptador
    {
        /// <summary>
        /// Este metodo encripta una cadena
        /// </summary>
        /// <param name="pCadena"></param> Corresponde a la cadena a encriptar
        /// <returns></returns> Devuelve la cadena encriptada
        public abstract string Encriptar(string pCadena);

        /// <summary>
        /// Este metodo desencripta una cadena
        /// </summary>
        /// <param name="pCadena"></param> Corresponde a la cadena a desencriptar
        /// <returns></returns> Devuelve la cadena desencriptada
        public abstract string Desencriptar(string pCadena);
    }
}
