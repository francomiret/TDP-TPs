using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital iHospital = new Hospital();
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("HOSPITAL                                 Consultas: " + iHospital.ObtenerCantidadDeConsultas());
                Console.WriteLine("                                         Urgencias: " + iHospital.ObtenerCantidadDeUrgencias());
                Console.WriteLine("1- Agregar consulta");
                Console.WriteLine("2- Siguiente consulta");
                Console.WriteLine();
                Console.WriteLine("3- Agregar urgencia");
                Console.WriteLine("4- Siguiente urgencia");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        {
                            Console.Write("Nombre de paciente: ");
                            string iNombre = Console.ReadLine();
                            Console.Write("Descripcion: ");
                            string iDescripcion = Console.ReadLine();
                            iHospital.AgregarConsulta(iNombre, iDescripcion);
                            break;
                        }
                    case "2":
                        {
                            InformacionDeTurno turno = iHospital.SiguienteConsulta();
                            Console.WriteLine("Nombre de paciente: " + turno.ObtenerNombreDePaciente);
                            Console.WriteLine("Descripcion: " + turno.ObtenerDescripcion);
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Nombre de paciente: ");
                            string iNombre = Console.ReadLine();
                            Console.Write("Descripcion: ");
                            string iDescripcion = Console.ReadLine();
                            Console.Write("Nivel de urgencia: ");
                            string iNivel = Console.ReadLine();
                            iHospital.AgregarUrgencia(iNombre, iDescripcion, Int32.Parse(iNivel));
                            break;
                        }
                    case "4":
                        {
                            InformacionDeTurno turno = iHospital.SiguienteUrgencia();
                            Console.WriteLine("Nombre de paciente: " + turno.ObtenerNombreDePaciente);
                            Console.WriteLine("Descripcion: " + turno.ObtenerDescripcion);
                            Console.ReadKey();
                            break;
                        }
                }
            } while (true);
        }
    }
}
