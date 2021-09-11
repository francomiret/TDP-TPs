using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Banca
    {   private Cuenta iCuentaPesos;
        private Cuenta iCuentaDolares;
        private string iNumero;
        private string iTitular;

        //CONSTRUCTOR
        public Banca(string pNumero, string pTitular)
        {
            this.iNumero = pNumero;
            this.iTitular = pTitular;
            Moneda monedaUsd = new Moneda("1", "Dolar", "uss");
            Moneda monedaPeso = new Moneda("2", "Peso", "s");
            this.iCuentaPesos = new Cuenta(monedaPeso);
            this.iCuentaDolares = new Cuenta(monedaUsd);
        }




        public Cuenta CuentaEnPesos
        {
            get { return this.iCuentaPesos; }
            

        }

        public Cuenta CuentaEnDolares
        {
            get { return this.iCuentaDolares; }
            
        }

        public string Numero
        {
            get { return this.iNumero; }
        }

        public string Titular
        {
            get { return this.iTitular; }
        }


    }
}
