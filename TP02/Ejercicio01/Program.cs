using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
  








    class Program
    {
        static void Main(string[] args)
        {
            Fachada cliente = new Fachada();
            Console.WriteLine("c - Circulo");
            Console.WriteLine("t - Triangulo");
            Console.WriteLine("Ingrese tipo de figura:  ");
            char tipoFigura = Convert.ToChar(Console.ReadLine());
            switch (tipoFigura)
            {
                case 'c':
                    Console.WriteLine("Ingrese el Radio: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese componente en X: ");
                    double pX = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese componente en Y: ");
                    double pY = Convert.ToDouble(Console.ReadLine());                                     
                    Console.WriteLine("Ingrese la letra correspondiente a la accion que desea realizar");
                    Console.WriteLine("a - Area del Circulo");
                    Console.WriteLine("p - Perimetro del Circulo");
                    int op = Convert.ToChar(Console.ReadLine());
                    
                    switch (op)
                    {
                        case 'a':
                            double area = cliente.AreaCirculo(radio, pX, pY);
                            Console.WriteLine("Area: " + area);
                            Console.ReadKey();
                            break;
                        case 'p':
                            double per = cliente.PerimetroCirculo(radio, pX, pY);
                            Console.WriteLine("Perimetro: " + per);
                            Console.ReadKey();
                            break;
                    }
                    break;

                    case 't':
                    ///LECTURA DE LOS 3 PUNTOS
                    Console.WriteLine("Ingrese componente en X del punto 1: ");
                    double p1X = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese componente en Y del punto 1: ");
                    double p1Y = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Ingrese componente en X del punto 2: ");
                    double p2X = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese componente en Y del punto 2: ");
                    double p2Y = Convert.ToDouble(Console.ReadLine());
                 
                    Console.WriteLine("Ingrese componente en X del punto 3: ");
                    double p3X = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese componente en Y del punto 3: ");
                    double p3Y = Convert.ToDouble(Console.ReadLine());
                
                  

                    Console.WriteLine("Ingrese la letra correspondiente a la accion que desea realizar");
                    Console.WriteLine("a - Area del Triangulo");
                    Console.WriteLine("p - Perimetro del Triangulo");
                    int op1 = Convert.ToChar(Console.ReadLine());
                    switch (op1)
                    {
                        case 'a':
                            double area = cliente.AreaTriangulo(p1X, p1Y, p2X, p2Y, p3X, p3Y);
                            Console.WriteLine("Area: " + area);
                            Console.ReadKey();
                            break;
                        case 'p':
                            double per = cliente.PerimetroTriangulo(p1X, p1Y, p2X, p2Y, p3X, p3Y); 
                            Console.WriteLine("Perimetro: " + per);
                            Console.ReadKey();
                            break;
                    }
                    break;
                    
            }

        }
    }
}
