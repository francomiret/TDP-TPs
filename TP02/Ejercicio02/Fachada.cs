namespace Ejercicio02
{
    class Fachada
    {
        private RepositorioBanca repositorioBanca = new RepositorioBanca();

        /// <summary>
        /// ESTE METODO CREA UNA CUENTA
        /// </summary>
        /// <param name="pNumero"></param> CORRESPONDE AL NUMERO DEL TITULAR
        /// <param name="pTitular"></param> CORRESPONDE AL NOMBRE DEL TITULAR
        /// <returns></returns> DEVUELVE EL ESTADO DE LA OPERACION
        public bool CrearCuentaUnificada(string pNumero, string pTitular)
        {
            Banca jBanca = repositorioBanca.Obtener(pNumero);
            if (jBanca == null)
            {
                Banca iBanca = new Banca(pNumero, pTitular);         //CREACION DE LA CUENTA  
                bool agrego = repositorioBanca.Agregar(iBanca);
                if (agrego)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ESTE METODO ACREDITA SALDO EN DOLARES
        /// </summary>
        /// <param name="pNumero"></param> CORRESPONDE AL NUMERO DE CUENTA
        /// <param name="pSaldo"></param> CORRESPONDE AL NOMBRE DEL TITULAR
        /// <returns></returns> DEVUELVE EL ESTADO DE LA OPERACION
        public bool AcreditarSaldoDolares(string pNumero, double pSaldo)
        {
            Banca pBanca = repositorioBanca.Obtener(pNumero); //BUSCA LA CUENTA
            if (pBanca == null)
            { return false; }
            else
            {
                pBanca.CuentaEnDolares.AcreditarSaldo(pSaldo);
                return true;
            }

        }

        /// <summary>
        /// ESTE METODO ACREDITA SALDO EN PESOS
        /// </summary>
        /// <param name="pNumero"></param> CORRESPONDE AL NUMERO DE CUENTA
        /// <param name="pSaldo"></param> CORRESPONDE AL NOMBRE DEL TITULAR
        /// <returns></returns> DEVUELVE EL ESTADO DE LA OPERACION
        public bool AcreditarSaldoPesos(string pNumero, double pSaldo)
        {
            Banca pBanca = repositorioBanca.Obtener(pNumero); //BUSCA LA CUENTA
            if (pBanca == null)
            { return false; }
            else
            {
                pBanca.CuentaEnPesos.AcreditarSaldo(pSaldo);
                return true;
            }

        }

        /// <summary>
        /// ESTE METODO DEBITA SALDO EN DOLARES
        /// </summary>
        /// <param name="pNumero"></param> CORRESPONDE AL NUMERO DE CUENTA
        /// <param name="pSaldo"></param> CORRESPONDE AL NOMBRE DEL TITULAR
        /// <returns></returns> DEVUELVE EL ESTADO DE LA OPERACION
        public bool DebitarSaldoDolares(string pNumero, double pSaldo)
        {
            Banca pBanca = repositorioBanca.Obtener(pNumero); //BUSCA LA CUENTA
            if (pBanca == null)
            { return false; }
            else
            {
                pBanca.CuentaEnDolares.DebitarSaldo(pSaldo);
                return true;
            }

        }

        /// <summary>
        /// ESTE METODO DEBITA SALDO EN PESOS
        /// </summary>
        /// <param name="pNumero"></param> CORRESPONDE AL NUMERO DE CUENTA
        /// <param name="pSaldo"></param> CORRESPONDE AL NOMBRE DEL TITULAR
        /// <returns></returns> DEVUELVE EL ESTADO DE LA OPERACION
        public bool DebitarSaldoPesos(string pNumero, double pSaldo)
        {
            Banca pBanca = repositorioBanca.Obtener(pNumero);
            if (pBanca == null)
            { return false; }
            else
            {
                pBanca.CuentaEnPesos.DebitarSaldo(pSaldo);
                return true;
            }
        }

        /// <summary>
        /// ESTE METODO CONSULTA EL SALDO EN PESOS
        /// </summary>
        /// <param name="pNumero"></param> CORRESPONDE AL NUMERO DE CUENTA
        /// <returns></returns> DEVUELVE EL SALDO EN PESOS DE LA CUENTA AL MOMENTO DE LA CONSULTA
        public TipoConsulta ConsultaSaldoPeso(string pNumero)
        {
            TipoConsulta res;
            Banca iBanca = repositorioBanca.Obtener(pNumero);
            if (iBanca == null)
            {
                res = new TipoConsulta(0, false);
                return res;
            }
            res = new TipoConsulta(iBanca.CuentaEnPesos.Saldo, true);
            return res;
        }

        /// <summary>
        /// ESTE METODO CONSULTA EL SALDO EN PESOS
        /// </summary>
        /// <param name="pNumero"></param> CORRESPONDE AL NUMERO DE CUENTA
        /// <returns></returns> DEVUELVE EL SALDO EN DOLARES DE LA CUENTA AL MOMENTO DE LA CONSULTA
        public TipoConsulta ConsultaSaldoDolar(string pNumero)
        {
            TipoConsulta res;
            Banca iBanca = repositorioBanca.Obtener(pNumero);
            if (iBanca == null)
            {
                res = new TipoConsulta(0, false);
                return res;
            }
            res = new TipoConsulta(iBanca.CuentaEnDolares.Saldo, true);
            return res;
        }


        /// <summary>
        /// ESTE METODO REALIZA UNA TRANSFERENCIA A OTRA CUENTA
        /// </summary>
        /// <param name="pNumeroEmisor"></param> CORRESPONDE AL NUMERO DE CUENTA EMISOR
        /// <param name="pNumeroReceptor"></param> CORRESPONDE AL NUMERO DE CUENTA RECEPTOR
        /// <param name="pSaldo"></param> CORRESPONDE AL SALDO QUE SE TRANSFIERE
        /// <returns></returns> DEVUELVE EL ESTADO DE LA OPERACION
        public bool TransferenciaEnPesos(string pNumeroEmisor, string pNumeroReceptor, double pSaldo)
        {
            bool exitoso;
            Banca iBancaE = repositorioBanca.Obtener(pNumeroEmisor);
            Banca iBancaR = repositorioBanca.Obtener(pNumeroReceptor);
            if ((iBancaE == null) || (iBancaR == null))
            {
                exitoso = false;
            }
            else
            {
                exitoso = iBancaE.CuentaEnPesos.DebitarSaldo(pSaldo);
                if (exitoso)
                {
                    iBancaR.CuentaEnPesos.AcreditarSaldo(pSaldo);
                }
            }
            return exitoso;

        }

        /// <summary>
        /// ESTE METODO REALIZA UNA TRANSFERENCIA A OTRA CUENTA
        /// </summary>
        /// <param name="pNumeroEmisor"></param> CORRESPONDE AL NUMERO DE CUENTA EMISOR
        /// <param name="pNumeroReceptor"></param> CORRESPONDE AL NUMERO DE CUENTA RECEPTOR
        /// <param name="pSaldo"></param> CORRESPONDE AL SALDO QUE SE TRANSFIERE
        /// <returns></returns> DEVUELVE EL ESTADO DE LA OPERACION
        public bool TransferenciaEnDolares(string pNumeroEmisor, string pNumeroReceptor, double pSaldo)
        {
            bool exitoso;
            Banca iBancaE = repositorioBanca.Obtener(pNumeroEmisor);
            Banca iBancaR = repositorioBanca.Obtener(pNumeroReceptor);
            if ((iBancaE == null) || (iBancaR == null))
            {
                exitoso = false;
            }
            else
            {
                exitoso = iBancaE.CuentaEnDolares.DebitarSaldo(pSaldo);
                if (exitoso)
                {
                    iBancaR.CuentaEnDolares.AcreditarSaldo(pSaldo);
                }
            }
            return exitoso;

        }

    }






    }


