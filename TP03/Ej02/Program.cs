using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 - Circulo");
            Console.WriteLine("2 - Triangulo");
            Console.Write("Seleccione una figura: ");
            string opcion = Console.ReadLine();
            Fachada iFachada = new Fachada();

            switch (opcion)
            {
                case "1":
                    {
                        Console.WriteLine("SE DESEA CONSTRUIR UN CIRCULO");
                        Console.WriteLine("Ingresar punto central");
                        Console.Write("X: ");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("Y: ");
                        double y = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar radio deseado");
                        Console.Write("RADIO: ");
                        double radio = double.Parse(Console.ReadLine());

                        Console.WriteLine(" ");
                        Console.WriteLine("DATOS DEL CIRCULO");
                        Console.WriteLine("Centro: (" + x + " , " + y + ")");
                        Console.WriteLine("Radio: " + radio);
                        Console.WriteLine("Area: " + iFachada.ObtenerAreaCirculo(radio));
                        Console.WriteLine("Perimetro: " + iFachada.ObtenerPerimetroCirculo(radio));
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("SE DESEA CONSTRUIR UN TRIANGULO");
                        Console.WriteLine("Ingresar primer punto");
                        Console.Write("X: ");
                        double x1 = double.Parse(Console.ReadLine());
                        Console.Write("Y: ");
                        double y1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar segundo punto");
                        Console.Write("X: ");
                        double x2 = double.Parse(Console.ReadLine());
                        Console.Write("Y: ");
                        double y2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar tercer punto");
                        Console.Write("X: ");
                        double x3 = double.Parse(Console.ReadLine());
                        Console.Write("Y: ");
                        double y3 = double.Parse(Console.ReadLine());

                        Console.WriteLine(" ");
                        Console.WriteLine("DATOS DEL TRIANGULO");
                        Console.WriteLine("P1: (" + x1 + " , " + y1 + ")");
                        Console.WriteLine("P2: (" + x2 + " , " + y2 + ")");
                        Console.WriteLine("P3: (" + x3 + " , " + y3 + ")");
                        Console.WriteLine("Area: " + iFachada.ObtenerAreaTriangulo(x1, y1, x2, y2, x3, y3));
                        Console.WriteLine("Perimetro: " + iFachada.ObtenerPerimetroTriangulo(x1,y1,x2,y2,x3,y3));
                    }
                    break;
                default: Console.WriteLine("Opcion invalida");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            Program.Main(args);
        }
    }
}
