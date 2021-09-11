using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{
    class Circulo
    {
        private double iRadio;
        private Punto iCentro;
        /// <summary>
        /// Crea un nuevo circulo
        /// </summary>
        /// <param name="pCentro">Punto que sera el centro del circulo</param>
        /// <param name="pRadio">Double que contiene el radio del circulo</param>
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }
        /// <summary>
        /// Crea un nuevo circulo
        /// </summary>
        /// <param name="pX">Double que contiene el valor de X del centro del circulo</param>
        /// <param name="pY">Double que contiene el valor de Y del centro del circulo</param>
        /// <param name="pRadio">Double que contiene el radio del circulo</param>
        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro = new Punto(pX, pY);
            this.iRadio = pRadio;
        }
        /// <summary>
        /// Devuelve el Punto que es centro del circulo
        /// </summary>
        public Punto Centro
        {
            get { return this.iCentro; }
        }
        /// <summary>
        /// Devuelve el radio del circulo
        /// </summary>
        public double Radio
        {
            get { return this.iRadio; }
        }
        /// <summary>
        /// Devuelve el area del circulo
        /// </summary>
        public double Area
        {
            get { return (Math.PI * Math.Pow(this.iRadio, 2)); }
        }
        /// <summary>
        /// Devuelve el perimetro del circulo
        /// </summary>
        public double Perimetro
        {
            get { return (2 * Math.PI * this.iRadio); }
        }
    }
}
