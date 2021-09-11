using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion = 'p';
            Fachada cliente = new Fachada();
            while (opcion != 't')
            {
                
                Console.WriteLine("Para crear una cuenta - Presione 1");
                Console.WriteLine("Para realizar operaciones con su cuenta - Presione 2");
                Console.WriteLine("Para realizar una transferencia bancaria - Presione 3");
                Console.WriteLine("Seleccione la opcion deseada ");
                char op = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '1':
                        Console.WriteLine("Ingrese su DNI: ");
                        string pNumero = Console.ReadLine();
                        Console.WriteLine("Ingrese su Nombre: ");
                        string pTitular = Console.ReadLine();
                        bool creada = cliente.CrearCuentaUnificada(pNumero, pTitular);
                        if (creada)
                        {
                            Console.WriteLine("Cuenta Creada exitosamente.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No se pudo crear la Cuenta");
                            Console.ReadKey();
                        }
                        break;

                    case '2':
                        Console.WriteLine("Acreditar saldo en pesos - Presione 1");
                        Console.WriteLine("Acreditar saldo en dolares - Presione 2");
                        Console.WriteLine("Debitar saldo en pesos - Presione 3");
                        Console.WriteLine("Debitar saldo en dolares - Presione 4");
                        Console.WriteLine("Para consultar saldo - Presione 5");

                        Console.WriteLine("Seleccione la opcion deseada ");
                        char op1 = Convert.ToChar(Console.ReadLine());
                        switch (op1)
                        {
                            case '1':
                                Console.WriteLine("Ingrese el numero de cuenta a operar: ");
                                string pNumero1 = Console.ReadLine();
                                Console.WriteLine("Ingrese el saldo a a acreidtar: ");
                                double pSaldo = Convert.ToDouble(Console.ReadLine());
                                bool listo = cliente.AcreditarSaldoPesos(pNumero1, pSaldo);
                                if (listo)
                                { Console.WriteLine("Acreditacion realizada con exito"); Console.ReadKey(); }
                                else
                                { Console.WriteLine("No se pudo acreditar, verifique los datos ingresado"); Console.ReadKey(); }
                                break;

                            case '2':
                                Console.WriteLine("Ingrese el numero de cuenta a operar: ");
                                string pNumero2 = Console.ReadLine();
                                Console.WriteLine("Ingrese el saldo a a acreidtar: ");
                                double pSaldo2 = Convert.ToDouble(Console.ReadLine());
                                bool listo2 = cliente.AcreditarSaldoDolares(pNumero2, pSaldo2);
                                if (listo2)
                                { Console.WriteLine("Acreditacion realizada con exito"); Console.ReadKey(); }
                                else
                                { Console.WriteLine("No se pudo acreditar, verifique los datos ingresado"); Console.ReadKey(); }
                                break;

                            case '3':
                                Console.WriteLine("Ingrese el numero de cuenta a operar: ");
                                string pNumero3 = Console.ReadLine();
                                Console.WriteLine("Ingrese el saldo a a acreidtar: ");
                                double pSaldo3 = Convert.ToDouble(Console.ReadLine());
                                bool listo3 = cliente.DebitarSaldoPesos(pNumero3, pSaldo3);
                                if (listo3)
                                { Console.WriteLine("Debitado con exito"); Console.ReadKey(); }
                                else
                                { Console.WriteLine("No se pudo debitar, verifique sus datos"); Console.ReadKey(); }
                                break;

                            case '4':
                                Console.WriteLine("Ingrese el numero de cuenta a operar: ");
                                string pNumero4 = Console.ReadLine();
                                Console.WriteLine("Ingrese el saldo a a acreidtar: ");
                                double pSaldo4 = Convert.ToDouble(Console.ReadLine());
                                bool listo4 = cliente.DebitarSaldoDolares(pNumero4, pSaldo4);
                                if (listo4)
                                { Console.WriteLine("Debitado con exito"); Console.ReadKey(); }
                                else
                                { Console.WriteLine("No se pudo debitar, verifique sus datos"); Console.ReadKey(); }
                                break;

                            case '5':
                                Console.WriteLine("Cuenta en pesos - Presione 1");
                                Console.WriteLine("Cuenta en dolares - Presione 2");
                                Console.WriteLine("Seleccione la opcion deseada");
                                char op3 = Convert.ToChar(Console.ReadLine());
                                switch (op3)
                                {
                                    case '1':
                                        Console.WriteLine("Ingrese el numero de cuenta ");
                                        String pNumeroCP = Console.ReadLine(); // NUMERO DE CUENTA CONSULTA EN PESOS
                                        TipoConsulta resultadoP = cliente.ConsultaSaldoPeso(pNumeroCP);
                                        if (resultadoP.Existe == true)
                                        {
                                            Console.WriteLine("Saldo: " + resultadoP.Valor);
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Cuenta Inexistente");
                                            Console.ReadKey();
                                        }
                                        break;
                                    case '2':
                                        Console.WriteLine("Ingrese el numero de cuenta ");
                                        String pNumeroCD = Console.ReadLine(); // NUMERO DE CUENTA CONSULTA EN DOLARES
                                        TipoConsulta resultadoD = cliente.ConsultaSaldoPeso(pNumeroCD);
                                        if (resultadoD.Existe == true)
                                        {
                                            Console.WriteLine("Saldo: " + resultadoD.Valor);
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Cuenta Inexistente");
                                            Console.ReadKey();
                                        }

                                        break;
                                }
                                break;
                        }
                        break;

                    case '3':
                        Console.WriteLine("Transferencia en dolares - Presione 1");
                        Console.WriteLine("Transferencia en pesos - Presione 2");
                        Console.WriteLine("Seleccione la opcion deseada ");
                        char op2 = Convert.ToChar(Console.ReadLine());
                        switch (op2)
                        {
                            case '1':
                                Console.WriteLine("Ingrese el numero de cuenta Origen: ");
                                string pNumeroEmisorD = Console.ReadLine();
                                Console.WriteLine("Ingrese el numero de cuenta Destino: ");
                                string pNumeroReceptorD = Console.ReadLine();
                                Console.WriteLine("Ingrese el monto a transferir: ");
                                double pSaldoD = Convert.ToDouble(Console.ReadLine());
                                bool tlistoD = cliente.TransferenciaEnDolares(pNumeroEmisorD, pNumeroReceptorD, pSaldoD);
                                if (tlistoD)
                                { Console.WriteLine("Transferencia realizada exitosamente"); Console.ReadKey(); }
                                else
                                { Console.WriteLine("No se pudo realizar la transferencia"); Console.ReadKey(); }
                                break;
                            case '2':
                                Console.WriteLine("Ingrese el numero de cuenta Origen: ");
                                string pNumeroEmisorP = Console.ReadLine();
                                Console.WriteLine("Ingrese el numero de cuenta Destino: ");
                                string pNumeroReceptorP = Console.ReadLine();
                                Console.WriteLine("Ingrese el monto a transferir: ");
                                double pSaldoP = Convert.ToDouble(Console.ReadLine());
                                bool tlistoP = cliente.TransferenciaEnPesos(pNumeroEmisorP, pNumeroReceptorP, pSaldoP);
                                if (tlistoP)
                                { Console.WriteLine("Transferencia realizada exitosamente"); Console.ReadKey(); }
                                else
                                { Console.WriteLine("No se pudo realizar la transferencia"); Console.ReadKey(); }
                                break;

                        }
                        break;
                }







                Console.Clear();
                Console.WriteLine("presione t para salir");
                opcion = Convert.ToChar(Console.ReadLine());
            } 
        }
    }
}
