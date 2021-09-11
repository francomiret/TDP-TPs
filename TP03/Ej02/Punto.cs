using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    public class Punto
    {
        private double iX, iY;
        /// <summary>
        /// Crea un nuevo punto
        /// </summary>
        /// <param name="pX">Double que contiene el valor de la variable X</param>
        /// <param name="pY">Double que contiene el valor de la variable Y</param>
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }
        /// <summary>
        /// Devuelve el valor de la variable X
        /// </summary>
        public double X
        {
            get { return this.iX; }
        }
        /// <summary>
        /// Devuelve el valor de la variable Y
        /// </summary>
        public double Y
        {
            get { return this.iY; }
        }
        /// <summary>
        /// Devuelve la distancia entre este punto y otro
        /// </summary>
        /// <param name="otroPunto">Punto del que se quiere calcular la distancia</param>
        /// <returns></returns>
        public double CalcularDistanciaDesde(Punto otroPunto)
        {
            return Math.Sqrt(Math.Pow(this.X - otroPunto.X, 2) + Math.Pow(this.Y - otroPunto.Y, 2));
            //Devuelve la norma del vector que forman los dos puntos
        }
    }
}
