using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Fachada
    {
        private Partida partida;
        public bool NuevaPartida(string pPalabra, bool pGano)
        {
            partida = new Partida(pPalabra, pGano);
            

            if (partida != null)
            {
                return true;
            }
            else { return false; }
        }

        public bool ConsultaBool(char pLetra, string pPalabra)
        {
            TipoIntento res = partida.Intento(pLetra, pPalabra);
            return res.Esta;
        }

        public int ConsultaInt(char pLetra, string pPalabra)
        {
            TipoIntento res = partida.Intento(pLetra,pPalabra);
            return res.Pos;
        }

        public int ConsultaCantidad(char pLetra, string pPalabra)
        {
            TipoIntento res = partida.Intento(pLetra,pPalabra)
                ;
            return res.CantidadRepetida;
        }

        public string ConsutaPalabraMod(char pLetra, string pPalabra)
        {
            TipoIntento res = partida.Intento(pLetra,pPalabra);
            return res.PalabraMod;
        }


        public string SeleccionPalabra()
        {
            //Random r = new Random();
            //int aleatorio = r.Next(0, 1);
           string[] vec = new string[1];
            //vec[0] = "avion";
            //vec[1] = "axioma";
            //vec[2] = "antropologo";
            //vec[3] = "geoestacionario";
            //vec[4] = "geoda";
            //vec[5] = "wanaco";
            //vec[6] = "marsupial";

            //vec[7] = "extintor";
            //vec[8] = "mohamed";

            vec[0] = "pastrami";

            return vec[0];
                
            
        }


    }
}
