using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    /// <summary>
    /// Esta clase corresponde al Encriptador cesar 
    /// </summary>
    public class EncriptadorCesar : Encriptador
    {
        private readonly byte iDesplazamiento;
        /// <summary>
        /// Este metodo crea una instancia de EncriptadorCesar
        /// </summary>
        /// <param name="pDesplazamiento">Byte que contiene el desplazamiento usado</param>
        public EncriptadorCesar(byte pDesplazamiento) : base("Cesar")
        {
            iDesplazamiento = pDesplazamiento;
        }
        /// <summary>
        /// Este metodo encripta una string utilizando el metodo Cesar
        /// </summary>
        /// <param name="pCadena">String que contiene la cadena a encriptar</param>
        /// <returns></returns> Devuelve la cadena encriptada
        public override string Encriptar(string pCadena)
        {
            byte[] iCadenaAscii = Encoding.ASCII.GetBytes(pCadena.ToCharArray());
            for (int i = 0; i < pCadena.Length; i++)
            {
                if ((iCadenaAscii[i] >= 65) && (iCadenaAscii[i] <= 90))
                {
                    iCadenaAscii[i] += iDesplazamiento;
                    if (iCadenaAscii[i] > 90) iCadenaAscii[i] -= 26;
                }
                else if ((iCadenaAscii[i] >= 96) && (iCadenaAscii[i] <= 122))
                    {
                    iCadenaAscii[i] += iDesplazamiento;
                    if (iCadenaAscii[i] > 122) iCadenaAscii[i] -= 26;
                    }
            }
            return Encoding.ASCII.GetString(iCadenaAscii);
        }
        /// <summary>
        /// Este metodo desencripta una string utilizando el metodo Cesar
        /// </summary>
        /// <param name="pCadena">String que contiene la cadena a desencriptar</param>
        /// <returns></returns> Devuelve la cadena desencriptada
        public override string Desencriptar(string pCadena)
        {
            byte[] iCadenaAscii = Encoding.ASCII.GetBytes(pCadena.ToCharArray());
            for (int i = 0; i < pCadena.Length; i++)
            {
                if ((iCadenaAscii[i] >= 65) && (iCadenaAscii[i] <= 90))
                {
                    iCadenaAscii[i] -= iDesplazamiento;
                    if (iCadenaAscii[i] < 65) iCadenaAscii[i] += 26;
                }
                else if ((iCadenaAscii[i] >= 96) && (iCadenaAscii[i] <= 122))
                {
                    iCadenaAscii[i] -= iDesplazamiento;
                    if (iCadenaAscii[i] < 96) iCadenaAscii[i] += 26;
                }
            }
            return Encoding.ASCII.GetString(iCadenaAscii);
        }
    }
}
