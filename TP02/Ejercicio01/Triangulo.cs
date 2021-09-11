using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = new Punto(pPunto1.X, pPunto1.Y);
            this.iPunto2 = new Punto(pPunto2.X, pPunto2.Y);
            this.iPunto3 = new Punto(pPunto3.X, pPunto3.Y);                  
        }

        public Punto Punto1
        {
            get { return this.iPunto1; }
        }

        public Punto Punto2
        {
            get { return this.iPunto2; }
        }

        public Punto Punto3
        {
            get { return this.iPunto3; }
        }
        
        /// <summary>
        /// ESTE METODO CALCULA EL AREA
        /// </summary>
        /// <returns></returns> DEVUELVE EL VALOR DEL AREA
        public double Area()
        {
            double a = this.iPunto1.X;
            double b = this.iPunto1.Y;

            double c = this.iPunto2.X;
            double d = this.iPunto2.Y;

            double e = this.iPunto3.X;
            double f = this.iPunto3.Y;

            double res = Math.Abs(a * d + c * f + e * b + (-b * c - d * e - f * a));

            return res/2;

        }

        /// <summary>
        /// ESTE METODO CALCULA EL PERIMETRO
        /// </summary>
        /// <returns></returns> DEVUELVE EL VALOR DEL PERIMETRO
        public double Perimetro() 
        {
            double lado12 = this.iPunto1.CalcularDistanciaDesde(iPunto2);
            double lado23 = this.iPunto2.CalcularDistanciaDesde(iPunto3);
            double lado31 = this.iPunto3.CalcularDistanciaDesde(iPunto1);

            return lado12 + lado23 + lado31;

        }
            
    }
}
