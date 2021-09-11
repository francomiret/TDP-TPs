using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Partida
    {

        private bool iGano;
        private string iPalabra;


        public Partida(string pPalabra, bool pGano)
        {

            this.iGano = pGano;
            this.iPalabra = pPalabra;
        }



        public TipoIntento Intento(char pLetra, string pPalabra)
        {
            int tam = pPalabra.Length;
            int i = 0;  
            bool esta = false;
            int c = 0;
            string pMod = pPalabra;
            int pos = 0;
            while (i < tam)
            {
                char letra = pPalabra[i]; 
                if (pLetra == letra)
                {
                    esta = true;
                    pos = i;
                    pMod = this.iPalabra.Remove(i,1);
                    c++;
                }

                i++;
            }
            TipoIntento res = new TipoIntento(esta, pos , pMod,c);
            return res;


        }

    }
}
