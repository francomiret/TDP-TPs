using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    public class Triangulo : FiguraGeometrica
    {
        private Punto iPunto1, iPunto2, iPunto3;
        public Triangulo(Punto p1,Punto p2,Punto p3)
        {
            this.iPunto1 = p1;
            this.iPunto2 = p2;
            this.iPunto3 = p3;
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
        public override double CalcularArea()
        {
            return (Math.Abs((this.iPunto3.X - this.iPunto1.X)*(this.iPunto2.Y - this.iPunto1.Y) 
                                    + (this.iPunto3.Y - this.iPunto1.Y)*(this.iPunto1.X - this.iPunto2.X)) / 2); 
            //Calcula el area como la mitad del producto escalar (en valor absoluto)
            //del vector perpendicular a AB por el vector AC
            //Area = 1/2 * |(C.X-A.X)(B.Y-A.Y) + (C.Y-A.Y)(A.X-B.X)|
        }
        public override double CalcularPerimetro()
        {
            return (this.iPunto1.CalcularDistanciaDesde(this.iPunto2)
                        + this.iPunto1.CalcularDistanciaDesde(this.iPunto3)
                        + this.iPunto2.CalcularDistanciaDesde(this.iPunto3));
            //Calcula el perimetro como la suma de las distancias entre puntos
        }
    }
}
