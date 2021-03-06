using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AgendaContext())
            {
                //Alta
                Persona mPersona = new Persona
                {
                    PersonaId = 1,
                    Nombre = "Juan",
                    Apellido = "Sanchez",
                    Telefonos = new List<Telefono>
                    {
                        new Telefono
                        {
                            TelefonoId = 1,
                            Numero = "555-123456",
                            Tipo = "Celular"
                        }
                    }
                };
                db.Personas.Add(mPersona);
                db.SaveChanges();

                // Busqueda
                foreach (var item in db.Personas)
                {
                    Console.WriteLine("Persona encontrada Nombre: {0}, Apellido: {1}, IdPersona:{2}",
                        item.Nombre,
                        item.Apellido,
                        item.PersonaId);
                }

                Console.ReadKey();

            }
        }
    }
}
