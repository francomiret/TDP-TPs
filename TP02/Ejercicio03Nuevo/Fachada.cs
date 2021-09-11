using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03Nuevo
{

    public class Fachada
    {
        private Partida iPartida;
        private RepositorioPalabra iRepositorioPalabra = new RepositorioPalabra();
        private RepositorioPartida iRepositorioPartida = new RepositorioPartida();

       /// <summary>
       /// ESTE METODO CREA UNA NUEVA PARTIDA 
       /// </summary>
       /// <param name="pNombre"></param> CORRESPONDE AL NOMBREA DEL JUGADOR
        public void NuevaPartida(string pNombre)
        {          
            this.iPartida = new Partida(pNombre);
            this.iRepositorioPartida.AgregarPartida(iPartida);
        }

        /// <summary>
        /// ESTE METODO COMPRUEBA SI LA LETRA ESTA EN LA PALABRA
        /// </summary>
        /// <param name="pLetra"></param> CORRESPONDE A LA LETRA QUE INGRESA EL JUGADOR
        /// <returns></returns> DEVUELVE LA PALABRA CON LAS LETRAS QUE ACERTO EL JUGADOR
       public string Intento(char pLetra)
        {
           return this.iPartida.Palabra.LetraEnPalabra(pLetra);
        }

        /// <summary>
        /// ESTE METODO COMPRUEBA SI LA LETRA ESTA EN LA PALABRA
        /// </summary>
        /// <param name="pLetra"></param>
        /// <returns></returns> DEVUELVE VERDADERO O FALSO
        public bool Esta(char pLetra)
        {
            return this.iPartida.Palabra.Esta(pLetra);
        }

        /// <summary>
        /// ESTE PROPIEDAD DEVUELVE LA LONGITU DE LA PALABRA
        /// </summary>
        public int LongitudPalabra
        {
           get { return this.iPartida.Palabra.getPalabra.Length; }
        }
      

        /// <summary>
        /// ESTE METODO DEVUELVE SI GANO LA PARTIDA
        /// </summary>
        /// <returns></returns> DEVUELVE VERDADERO O FALSO 
        public bool gano()
        {
            return this.iPartida.Palabra.Gano();
        }

        public void FinPartida()
        {
            this.iPartida.FinPartida();
        }

       

        public string NombreJugadorPartida(int pos)
        {          
            string nom = this.iRepositorioPartida.ObtenerNPartidas()[pos].Nombre;
            return nom;
        }
        /// <summary>
        /// ESTE METODO CALCULA LA DURACION EN BASE A LA HORA INICIO Y HORA FIN
        /// </summary>
        /// <param name="pos"></param> 
        /// <returns></returns> DEVULEVE LA DURACION
        public double DuracionPartida(int pos)
        {
            double duracion = this.iRepositorioPartida.ObtenerNPartidas()[pos].Duracion;
            return duracion;
        }
        public string PalabraPartida(int pos)
        {
            string pal = this.iRepositorioPartida.ObtenerNPartidas()[pos].Palabra.getPalabra;
            return pal;
        }

    }
}
