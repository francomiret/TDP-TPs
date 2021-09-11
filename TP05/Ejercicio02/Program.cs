using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.AccountManager;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            var banco = new Bank();
           // banco.CrearCliente("felipe", "cestau", "12312");
            int id = 1;
            double odl = -1000;
            int id2 = 7;
            DateTime date = DateTime.Now;
           // banco.CrearCuenta(id2, "dolares", odl);
           // banco.RegistrarMovimiento(id, id2, date, "dddd", odl);
            banco.CuentasConSobregiro();
        }
    }
}
