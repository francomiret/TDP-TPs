using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptionManager iManager = EncryptionManager.Instancia;


            Console.Write("Ingresar cadena: ");
            string cadena = Console.ReadLine();
            bool c = false, m = false, e = false, a = false;

            do
            {
                Console.Clear();
                Console.Write("  Cesar (C)  --  Mix (M)  --  Espejo (E)  --  AES (A)");
                Console.WriteLine();
                Console.WriteLine("  - " + cadena + " -");
                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case 'c':
                        {
                            if (c)
                                cadena = iManager.Desencriptar(cadena, "cesar");
                            else
                                cadena = iManager.Encriptar(cadena, "cesar");
                            c = !c;
                        }
                        break;
                    case 'm':
                        {
                            if (m)
                                cadena = iManager.Desencriptar(cadena, "mix");
                            else
                                cadena = iManager.Encriptar(cadena, "mix");
                            m = !m;
                        }
                        break;
                    case 'e':
                        {
                            if (e)
                                cadena = iManager.Desencriptar(cadena, "espejo");
                            else
                                cadena = iManager.Encriptar(cadena, "espejo");
                            e = !e;
                        }
                        break;
                    case 'a':
                        {
                            if (a)
                                cadena = iManager.Desencriptar(cadena, "aes");
                            else
                                cadena = iManager.Encriptar(cadena, "aes");
                            a = !a;
                        }
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
