using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03Nuevo
{
    public class Palabra
    {
        private string iPalabra;
        private string iPalabraActual;

        public Palabra(string pPalabra)
        {
            this.iPalabra = pPalabra;
            int tam = pPalabra.Length;
            for (int i=0; i<tam;i++)   //SI LA PALABRA ES HOLA INICIALIZA ****, ES DECIR CAMBIA CADA CARACTER POR UN ASTERISCO
            {
                this.iPalabraActual += "*";
            }                   
        }

        public string getPalabra
        {
            get { return this.iPalabra; }
        }
        public string getPalabraActual
        {
            get { return this.iPalabraActual; }
        }


        /// <summary>
        /// ESTE METDOO DEVUELVE LAS APARICIONES DE LA LETRA EN LA PALABRA
        /// </summary>
        /// <param name="letra"></param>
        /// <returns></returns> DEVUELVE LA PALABRA CON LAS APARICIONES DE LAS LETRAS INGRESADAS AL MOMENTO
        public string LetraEnPalabra(char letra)
        {
            int tam = this.iPalabraActual.Length;

            
            for (int i =0;i<tam;i++)
            {
                if ((this.iPalabra[i] == letra)&&(this.iPalabraActual[i] == '*'))
                {
                    int val = tam - i;
                    this.iPalabraActual = this.iPalabraActual.Substring(0, i) + letra + this.iPalabraActual.Substring(i + 1, val - 1);
                }
                else
                {                   
                }
               
            }
            return this.iPalabraActual;

        }

        public bool Esta(char pLetra)
        {
            int tam = this.iPalabra.Length;
            bool esta = false;
            int i = 0;
            while ((i<tam)&&(esta==false))
            {
                if (pLetra==this.iPalabra[i])
                {
                    esta = true;
                }
                i++;
            }
            return esta;
        }


        public bool Gano()
        {
            if (this.iPalabra == this.iPalabraActual)
            {
                return true;
            }
            else { return false; }
        }

    }
}
