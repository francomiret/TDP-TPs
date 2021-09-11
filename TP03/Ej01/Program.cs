using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro(), gato = new Gato(), vaca = new Vaca(), caballo = new Caballo();
            Veterinaria iVeterinaria = new Veterinaria();
            Animal[] coleccionDeAnimales = {perro, gato, vaca, caballo};
            iVeterinaria.AceptarAnimales(coleccionDeAnimales);

            Console.ReadKey();
        }
    }
}
