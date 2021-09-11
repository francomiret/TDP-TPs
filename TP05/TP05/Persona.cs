using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    class Persona
    {
        public int PersonaId {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public IList<Telefono> Telefonos {get; set;}

       
    }
}
