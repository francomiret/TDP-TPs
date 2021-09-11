using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Cuenta
    {
        private double iSaldo;
        private Moneda iMoneda;

        //CONSTRUCTOR
        public Cuenta(Moneda pMoneda)
        {
            this.iMoneda = new Moneda(pMoneda.CodigoISO,pMoneda.Nombre,pMoneda.Simbolo);
            this.iSaldo = 0;
        }

        //CONSTRUCTOR
        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;
            this.iMoneda = new Moneda(pMoneda.CodigoISO, pMoneda.Nombre, pMoneda.Simbolo);

        }

        public double Saldo
        {
            get { return this.iSaldo; }
        }

        /// <summary>
        /// ESTE METODO ACREDITA SALDO A AL CUENTA
        /// </summary>
        /// <param name="pSaldo"></param> CORRESPONDE AL SALDO A ACREDITAR
        public void AcreditarSaldo(double pSaldo)
        {
            this.iSaldo += pSaldo; // REALIZA LA ACREDITACION
        }

        /// <summary>
        /// ESTE METODO DEBITA SALDO DE LA CUENTA
        /// </summary>
        /// <param name="pSaldo"></param> CORRESPONDE AL SALDO A DEBITAR
        /// <returns></returns>
        public bool DebitarSaldo(double pSaldo)
        {
            bool debitado;
            if (this.iSaldo < pSaldo) //COMPRUEBA QUE NO SE PUEDA RETIRAR MAS DE LO QUE TIENE LA CUENTA AL MOMENTO DE DEBITAR
            {
                debitado = false;
            }
            else
            {
                this.iSaldo -= pSaldo; //REALIZA LA DEBITACION
                debitado = true;
            }
            return debitado;
            
            
        }
    }
}
