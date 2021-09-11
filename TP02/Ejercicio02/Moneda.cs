using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Moneda
    {
        private string iCodiogoISO;
        private string iNombre;
        private string iSimbolo;

        public Moneda(string pCodigo, string pNombre, string pSimbolo)
        {
            this.iCodiogoISO = pCodigo;
            this.iNombre = pNombre;
            this.iSimbolo = pSimbolo;
        }

        public string CodigoISO
        {
            get { return this.iCodiogoISO; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
        }

        public string Simbolo
        {
            get { return this.iSimbolo; }
        }
    }
}
