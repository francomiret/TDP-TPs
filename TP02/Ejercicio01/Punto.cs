using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
   public  class Punto
    {
        private double iX;
        private double iY;
      
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }
        public double Y
        {
            get {return this.iY;}
        }

        public double X
        {
            get { return this.iX; }
        }

        /// <summary>
        /// ESTE METODO CALULA LA DISTANCIA ENTRE DOS PUNTOS
        /// </summary>
        /// <param name="pPunto"></param>
        /// <returns></returns> DEVUELVE UN VALOR CORRESPONDIENTE A LA DISTANCIA
        public double CalcularDistanciaDesde(Punto pPunto)
        {           
            double componenteX = pPunto.iX - this.iX;
            double componenteY = pPunto.iY - this.iY;
            double norma = Math.Sqrt((Math.Pow(componenteX, 2)) + (Math.Pow(componenteY, 2))); //NORMA DEL VECTOR
            return norma;

        }
    }
}
