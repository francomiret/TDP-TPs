using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Fachada
    {
       
       


        //CIRCULO
        public double AreaCirculo(double pRadio,double pX, double pY)
        {
            Punto iCentro = new Punto(pX, pY);
            Circulo iCirculo = new Circulo(iCentro, pRadio);
            return iCirculo.Area();           
        }

        public double PerimetroCirculo(double pRadio, double pX, double pY)
        {
            Punto iCentro = new Punto(pX, pY);
            Circulo iCirculo = new Circulo(iCentro, pRadio);
            return iCirculo.Perimetro();
        }

        //TRIANGULO

        public double AreaTriangulo(double pX1, double pY1, double pX2, double pY2, double pX3, double pY3)
        {
            Punto iPunto1 = new Punto(pX1, pY1);
            Punto iPunto2 = new Punto(pX2, pY2);
            Punto iPunto3 = new Punto(pX3, pY3);
            Triangulo iTriangulo = new Triangulo(iPunto1, iPunto2, iPunto3);
            return iTriangulo.Area();
        }

        public double PerimetroTriangulo(double pX1, double pY1, double pX2, double pY2, double pX3, double pY3)
        {
            Punto iPunto1 = new Punto(pX1, pY1);
            Punto iPunto2 = new Punto(pX2, pY2);
            Punto iPunto3 = new Punto(pX3, pY3);
            Triangulo iTriangulo = new Triangulo(iPunto1, iPunto2, iPunto3);
            return iTriangulo.Perimetro();
        }
    }
}
