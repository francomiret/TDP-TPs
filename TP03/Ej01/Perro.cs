using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{
    public class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Ladrando");
        }
    }
}
