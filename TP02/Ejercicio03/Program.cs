using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada juego = new Fachada();

            Console.WriteLine("                   BIENVENIDO AL AHORCADO");
            
            string pSolucion = juego.SeleccionPalabra();
            char[] muestra = new char[pSolucion.Length];
            
            
            Console.WriteLine("                 La Palabra tiene: " + pSolucion.Length+ " letras");
            Console.WriteLine();
            juego.NuevaPartida(pSolucion,false);
            int intentos = 10;//pSolucion.Length+5;
            Console.WriteLine("                 Usted tiene: "+intentos+" Intentos");
            Console.WriteLine();
            int contador = 0;
            int tam = pSolucion.Length;
            int i = 0;
            
            while ((i<intentos)&&(contador!=tam))
            {
                Console.WriteLine("Ingrese una letra");
                char intento = Convert.ToChar(Console.ReadLine());
                bool acerto = juego.ConsultaBool(intento,pSolucion);
                if (acerto)
                {
                    
                    
                    int cant = juego.ConsultaCantidad(intento, pSolucion);
                    if (cant > 1)
                    {
                        pSolucion = juego.ConsutaPalabraMod(intento, pSolucion);
                    }
                    int pos = juego.ConsultaInt(intento,pSolucion);
                    Console.WriteLine("Correcto!!!! la letra se encuentra en la posicion: "+pos);
                    muestra[pos] = intento;
                    Console.WriteLine();
                    Console.WriteLine(muestra);
                    contador++;
                }
                else
                {
                    Console.WriteLine("Fallaste, prueba de nuevo");
                    i++;
                }
                
                
            }
            if (i>=intentos)
            {
                Console.WriteLine("Perdiste");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ganaste");
                Console.ReadKey();
            }

        }
    }
}
