using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03Nuevo
{
    class Program
    {
        static void Main(string[] args)

        {
            Fachada juego = new Fachada();
            int chances = 10;
            char tecla = 'a';

            while (tecla != 't')
            {
                Console.Clear();
                Console.WriteLine("          BIENVENIDO AL AHORCADO          ");
                Console.WriteLine();
                Console.WriteLine("NUEVO JUEGO - PRESIONE 1");
                Console.WriteLine("MEJORES PARTIDAS - PRESIONE 2");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese su Nombre: ");
                        string name = Console.ReadLine();
                        juego.NuevaPartida(name);
                        int i = 0;
                        bool gano = false;
                        while ((i <= chances) && (gano != true))
                        {
                            Console.WriteLine("Cantidad de Letras: "+juego.LongitudPalabra);
                            Console.WriteLine("Ingrese una Letra: ");
                            char letra = Convert.ToChar(Console.ReadLine());
                            string palabraActual = juego.Intento(letra);
                            Console.WriteLine(palabraActual);
                            if (juego.Esta(letra)!=true)
                            {
                                i++;
                            }
                            gano = juego.gano();
                            
                        
                        }
                        if (gano)
                        {
                            Console.WriteLine("Ganaste");
                            juego.FinPartida();
                        }
                        else
                        {
                            Console.WriteLine("Perdiste");
                            juego.FinPartida();
                        }
                        break;

                    case 2:
                        for (int pos = 0; pos < 2; pos++)
                        {
                            Console.WriteLine("jugador: " + juego.NombreJugadorPartida(pos));
                            Console.WriteLine("Palabra: " + juego.PalabraPartida(pos));
                            Console.WriteLine("Duracion: " + juego.DuracionPartida(pos)+" Seg");
                            Console.WriteLine();
                        }
                        break;





                }





                Console.ReadKey();
                Console.WriteLine("t para salir");
                tecla = Convert.ToChar(Console.ReadLine());
            }  
        }
    }
}
