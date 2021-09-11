using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03Nuevo
{
    public class RepositorioPartida
    {
        private Partida[] iRepositorioPartida = new Partida[10];


        /// <summary>
        /// ESTE METODO AGREGA UNA PARTIDA AL REPOSITORIO
        /// </summary>
        /// <param name="pPartida"></param>
        public void AgregarPartida(Partida pPartida)
        {
            int c = 0;
            int n = 30;
            for (int i = 0; i < n && c < 1; i++)
            {
                if (this.iRepositorioPartida[i] == null)
                {
                    this.iRepositorioPartida[i] = pPartida;
                    c++;

                }

            }

        }

        /// <summary>
        /// ESTE METODO REALIZA UN ORDENAMINETO BURBUJA
        /// </summary>
        public void OrdenarPartidas()
        {

            Partida aux;
            for (int a = 1; a < this.iRepositorioPartida.Length; a++)
                for (int b = this.iRepositorioPartida.Length - 1; b >= a; b--)
                {
                    if (this.iRepositorioPartida[b - 1].Duracion > this.iRepositorioPartida[b].Duracion)
                    {
                        aux = this.iRepositorioPartida[b - 1];
                        this.iRepositorioPartida[b - 1] = this.iRepositorioPartida[b];
                        this.iRepositorioPartida[b] = aux;
                    }
                }
        }

        /// <summary>
        /// OBTIENE N PARTIDAS DEL REPOSITORIO
        /// </summary>
        /// <returns></returns>
        public Partida[] ObtenerNPartidas()
        {
            OrdenarPartidas();
            int n = 5;
            Partida[] resultado = new Partida[n];
            for (int i = 0; i < n; i++)
            {
                resultado[i] = this.iRepositorioPartida[i];
            }
            return resultado;

        }



    }

}

