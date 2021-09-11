using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    /// <summary>
    /// Esta clase gestiona la creacion de encriptadores
    /// </summary>
    public sealed class FabricaEncriptadores
    {
        private static FabricaEncriptadores iInstancia = null;
        private Dictionary<String, IEncriptador> iDiccinario = new Dictionary<String, IEncriptador>();

        /// <summary>
        /// Este metodo agrega al diccionario los distintos encriptadores
        /// </summary>
        private FabricaEncriptadores()
        {
            iDiccinario.Add("cesar", new EncriptadorCesar(3));
            iDiccinario.Add("aes", new EncriptadorAES());
            iDiccinario.Add("mix", new EncriptadorMix());
            iDiccinario.Add("espejo", new EncriptadorEspejo());
        }

        /// <summary>
        /// Este metodo crea una instancia
        /// </summary>
        public static FabricaEncriptadores Instancia
        {
            get
            {
                if (iInstancia == null) iInstancia = new FabricaEncriptadores();
                return iInstancia;
            }
        }

        /// <summary>
        /// Este metodo devuelve un encriptador 
        /// </summary>
        /// <param name="pNombre"></param> Corresponde al nombre del encriptador deseado
        /// <returns></returns> Devuelve el encriptador
        public IEncriptador GetEncriptador(string pNombre)
        {
            if (!iDiccinario.TryGetValue(pNombre, out IEncriptador encriptador)) encriptador = new EncriptadorNulo();
            return encriptador;
        }
    }
}
