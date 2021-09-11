using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                NUMEROS COMPLEJOS                ");
            Console.WriteLine();

            Console.Write("Ingrese la parte Real: ");
            double real = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la parte Imaginaria: ");
            double img = Convert.ToDouble(Console.ReadLine());
            Complejo cmplx = new Complejo(real, img);
            char tecla = 'a';
            while (tecla != 'e')
            {
                Console.WriteLine();
                Console.WriteLine("                Operaciones                ");
                Console.WriteLine();
                Console.WriteLine("1- Consulta parte Real");
                Console.WriteLine("2- Consulta parte imaginaria");
                Console.WriteLine("3- Consultar si el numero es Real");
                Console.WriteLine("4- Consultar si el numero es Imaginario");
                Console.WriteLine("5- Es igual a ...");              
                Console.WriteLine("6- Magnitud");
                Console.WriteLine("7- Argumento en Radianes");
                Console.WriteLine("8- Argumento en Grados");
                Console.WriteLine("9- Conjugado");
                Console.WriteLine("10- Sumar ...");
                Console.WriteLine("11- Restar ...");
                Console.WriteLine("12- Multiplicar por ...");
                Console.WriteLine("13- Dividir por ...");
                Console.WriteLine("14- Es igual a ... (utiliza otro metodo)");
                Console.Write("INGRESE OPCION: ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("La parte Real es: " + cmplx.Real);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("La parte Imaginaria es: " + cmplx.Imaginario);
                        Console.ReadKey();
                        break;
                    case 3:
                        if (cmplx.EsReal())
                        {
                            Console.WriteLine("El numero es real");
                        }
                        else
                        { Console.WriteLine("El numero No es real"); }
                        Console.ReadKey();
                        break;
                    case 4:
                        if (cmplx.EsImaginario())
                        {
                            Console.WriteLine("El numero es Imaginario");
                        }
                        else
                        { Console.WriteLine("El numero No es Imaginario"); }
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Ingrese la parte Real del otro numero: ");
                        double real2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte Imaginaria del otro numero: ");
                        double img2 = Convert.ToDouble(Console.ReadLine());
                        Complejo cmplx2 = new Complejo(real2, img2);
                        Console.WriteLine();
                        if (cmplx.EsIgual(cmplx2))
                        {
                            Console.WriteLine("Los numeros son iguales");
                        }
                        else
                        {
                            Console.WriteLine("Los numeros no son iguales");
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("La magnitud es: " + cmplx.Magnitud());
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Argumento en radianes: " + cmplx.ArgumentoEnRadianes());
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Argumento en grados: " + cmplx.ArgumentoEnGrados() + "°");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Conjugado");
                        Console.WriteLine("Parte Real Conjugado: " + cmplx.Conjugado().Real);
                        Console.WriteLine("Parte Imaginaria Conjugado: " + cmplx.Conjugado().Imaginario);
                        Console.WriteLine("(" + cmplx.Conjugado().Real + "," + cmplx.Conjugado().Imaginario + "i)");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        Console.Write("Ingrese la parte Real del otro numero: ");
                        double realS2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte Imaginaria del otro numero: ");
                        double imgS2 = Convert.ToDouble(Console.ReadLine());
                        Complejo cmplxS2 = new Complejo(realS2, imgS2);
                        Console.WriteLine();
                        Console.WriteLine("Parte Real Suma: " + cmplx.Sumar(cmplxS2).Real);
                        Console.WriteLine("Parte Imaginaria Suma: " + cmplx.Sumar(cmplxS2).Imaginario);
                        Console.WriteLine("(" + cmplx.Sumar(cmplxS2).Real + "," + cmplx.Sumar(cmplxS2).Imaginario + "i)");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                        Console.Write("Ingrese la parte Real del otro numero: ");
                        double realR2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte Imaginaria del otro numero: ");
                        double imgR2 = Convert.ToDouble(Console.ReadLine());
                        Complejo cmplxR2 = new Complejo(realR2, imgR2);
                        Console.WriteLine();
                        Console.WriteLine("Parte Real Suma: " + cmplx.Restar(cmplxR2).Real);
                        Console.WriteLine("Parte Imaginaria Suma: " + cmplx.Restar(cmplxR2).Imaginario);
                        Console.WriteLine("(" + cmplx.Restar(cmplxR2).Real + "," + cmplx.Restar(cmplxR2).Imaginario + "i)");
                        Console.ReadKey();
                        break;
                    case 12:
                        Console.Clear();
                        Console.Write("Ingrese la parte Real del otro numero: ");
                        double realM2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte Imaginaria del otro numero: ");
                        double imgM2 = Convert.ToDouble(Console.ReadLine());
                        Complejo cmplxM2 = new Complejo(realM2, imgM2);
                        Console.WriteLine();
                        Console.WriteLine("Parte Real Suma: " + cmplx.MultiplicarPor(cmplxM2).Real);
                        Console.WriteLine("Parte Imaginaria Suma: " + cmplx.MultiplicarPor(cmplxM2).Imaginario);
                        Console.WriteLine("(" + cmplx.MultiplicarPor(cmplxM2).Real + "," + cmplx.MultiplicarPor(cmplxM2).Imaginario + "i)");
                        Console.ReadKey();
                        break;
                    case 13:
                        Console.Clear();
                        Console.Write("Ingrese la parte Real del otro numero: ");
                        double realD2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte Imaginaria del otro numero: ");
                        double imgD2 = Convert.ToDouble(Console.ReadLine());
                        Complejo cmplxD2 = new Complejo(realD2, imgD2);
                        Console.WriteLine();
                        Console.WriteLine("Parte Real Suma: " + cmplx.DividirPor(cmplxD2).Real);
                        Console.WriteLine("Parte Imaginaria Suma: " + cmplx.DividirPor(cmplxD2).Imaginario);
                        Console.WriteLine("(" + cmplx.DividirPor(cmplxD2).Real + "," + cmplx.DividirPor(cmplxD2).Imaginario + "i)");
                        Console.ReadKey();
                        break;

                    case 14:
                        Console.Clear();
                        Console.Write("Ingrese la parte Real del otro numero: ");
                        double realC2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la parte Imaginaria del otro numero: ");
                        double imgiC2 = Convert.ToDouble(Console.ReadLine());                       
                        Console.WriteLine();
                        if (cmplx.EsIgual(realC2, imgiC2))
                        {
                            Console.WriteLine("Los numeros son iguales");
                        }
                        else
                        {
                            Console.WriteLine("Los numeros no son iguales");
                        }
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Si desea salir Presione e");
                tecla = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Numero: " + "("+real +" "+ img +"i)");
            }

        }
    }
}