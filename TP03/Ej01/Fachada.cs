using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{
    class Fachada
    {
        /// <summary>
        /// Devuelve el area de un ciculo
        /// </summary>
        /// <param name="radio">Double que contiene el radio del circulo</param>
        /// <returns></returns>
        public double ObtenerAreaCirculo(double radio) 
        {
            Punto p = new Punto(0, 0);
            Circulo iCirculo = new Circulo(p, radio);
            return iCirculo.Area;
        }
        /// <summary>
        /// Devuelve el perimetro de un ciculo
        /// </summary>
        /// <param name="radio">Double que contiene el radio del circulo</param>
        /// <returns></returns>
        public double ObtenerPerimetroCirculo(double radio) 
        {
            Punto p = new Punto(0, 0);
            Circulo iCirculo = new Circulo(p, radio);
            return iCirculo.Perimetro;
        }
        /// <summary>
        /// Devuelve el area de un triangulo
        /// </summary>
        /// <param name="x1">Double que contiene el valor de X del primer vertice</param>
        /// <param name="y1">Double que contiene el valor de Y del primer vertice</param>
        /// <param name="x2">Double que contiene el valor de X del segundo vertice</param>
        /// <param name="y2">Double que contiene el valor de Y del segundo vertice</param>
        /// <param name="x3">Double que contiene el valor de X del tercer vertice</param>
        /// <param name="y3">Double que contiene el valor de Y del tercer vertice</param>
        /// <returns></returns>
        public double ObtenerAreaTriangulo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Punto p1 = new Punto(x1, y1), p2 = new Punto(x2 ,y2), p3 = new Punto(x3, y3);
            Triangulo iTriangulo = new Triangulo(p1, p2, p3);
            return iTriangulo.Area;
        }
        /// <summary>
        /// Devuelve el perimetro de un triangulo
        /// </summary>
        /// <param name="x1">Double que contiene el valor de X del primer vertice</param>
        /// <param name="y1">Double que contiene el valor de Y del primer vertice</param>
        /// <param name="x2">Double que contiene el valor de X del segundo vertice</param>
        /// <param name="y2">Double que contiene el valor de Y del segundo vertice</param>
        /// <param name="x3">Double que contiene el valor de X del tercer vertice</param>
        /// <param name="y3">Double que contiene el valor de Y del tercer vertice</param>
        /// <returns></returns>
        public double ObtenerPerimetroTriangulo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Punto p1 = new Punto(x1, y1), p2 = new Punto(x2, y2), p3 = new Punto(x3, y3);
            Triangulo iTriangulo = new Triangulo(p1, p2, p3);
            return iTriangulo.Perimetro;
        }
    }
}
