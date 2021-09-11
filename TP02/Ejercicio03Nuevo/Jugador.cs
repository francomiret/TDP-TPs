using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03Nuevo
{
    public class Jugador
    {

        private string iNombre;

        public Jugador(string pNombre)
        {
           
            this.iNombre = pNombre;
        }    
        public string Nombre
        {
            get { return this.iNombre; }
        }
      
    }
}
