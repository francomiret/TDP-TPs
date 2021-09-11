using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    /// <summary>
    /// Esta es una clase abstracta para encriptar y desencriptar una cadena a travez de distintos encriptadores
    /// </summary>
    public abstract class Encriptador : IEncriptador
    {
        protected readonly string iNombre;
        /// <summary>
        /// Este metodo inicializa el el nombre del encriptador
        /// </summary>
        /// <param name="pNombre"></param>
        protected Encriptador(string pNombre)
        {
            iNombre = pNombre;
        }
        /// <summary>
        /// este metodo devueleve el nombre del encripatodr
        /// </summary>
        public string Nombre => iNombre;
        /// <summary>
        /// Este Metodo Encriptar una cadena
        /// </summary>
        /// <param name="pCadena"></param> corresponde a la cadena a encriptar 
        /// <returns></returns> Devuelve la cadena encriptada
        public override abstract string Encriptar(string pCadena);

        /// <summary>
        /// Este metodo desencripta una cadena encriptada
        /// </summary>
        /// <param name="pCadena"></param> corresponde a la cadena a desencriptar
        /// <returns></returns> devuelve la cadena desencriptada
        public override abstract string Desencriptar(string pCadena);
    }
}
