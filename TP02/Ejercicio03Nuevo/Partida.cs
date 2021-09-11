using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03Nuevo
{
    public class Partida
    {
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
        private double iDuracion;
        private bool iGano;
        private Jugador iJugador;
        private Palabra iPalabra;
        
        
        

        public Partida(string pNombre)
        {
            RepositorioPalabra bdd = new RepositorioPalabra();
            this.iFechaInicio = DateTime.Now;
            this.iGano = false;
            this.iPalabra = new Palabra(bdd.SeleccionPalabra());
            this.iJugador = new Jugador(pNombre);
            
        }


        public Palabra Palabra
        {
            get { return this.iPalabra; }
        }

      

        public string Nombre
        {
            get { return this.iJugador.Nombre; }
        }

        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
        }

        public DateTime FechaFin
        {
            get { return this.iFechaFin; }
        }

        public double Duracion
        {
            get { return this.iDuracion; }
        }

        public void FinPartida()
        {
            this.iFechaFin = DateTime.Now;
            var horas = (this.iFechaFin - this.iFechaInicio).TotalSeconds;
            this.iDuracion = horas;
        }

       
    }
}
