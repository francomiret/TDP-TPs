using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class TipoConsulta
    {
        private double valor;
        private bool existe;

        public TipoConsulta(double pValor, bool pExsite)
        {
            this.existe = pExsite;
            this.valor = pValor;
        }

        public double Valor
        {
            get { return this.valor; }
        }

        public bool Existe
        {
            get { return this.existe; }
        }
    }
}
