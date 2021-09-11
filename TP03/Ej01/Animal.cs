using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{
    public abstract class Animal
    {
        public void Correr()
        {
            Console.WriteLine("Corriendo");
        }
        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }
        public abstract void HacerRuido();
    }
}
