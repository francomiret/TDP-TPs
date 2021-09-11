using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class TipoIntento
    {
        private bool iEsta;
        private int iPos;
        private string iPalabraMod;
        private int iCantRepetido;
        public TipoIntento(bool pEsta, int pPos, string pPalabra, int pCant)
        {
            this.iEsta = pEsta;
            this.iPos = pPos;
            this.iPalabraMod = pPalabra;
            this.iCantRepetido = pCant;
        }

        public bool Esta
        {
            get { return this.iEsta; }
        }

        public int Pos
        {
            get { return this.iPos; }
        }
        
        public string PalabraMod
        {
            get { return this.iPalabraMod; }
        }

        public int CantidadRepetida
        {
            get { return this.iCantRepetido; }
        }
    }
}
