using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{
    public class Veterinaria
    {
        public void AceptarAnimales(Animal[] coleccionDeAnimales)
        {
            foreach (Animal animal in coleccionDeAnimales)
            {
                animal.Correr();
                animal.Saltar();
                animal.HacerRuido();
                Console.WriteLine();
            }
        }
    }
}
