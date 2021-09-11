using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    public class SalaDeHospital
    {
        private List<Turno> iColaDeTurnos = new List<Turno>();
        private MetodoDeOrdenamiento iMetodoDeOrdenamiento;
        /// <summary>
        /// Crea una nueva sala de hospital con un metodo de ordenamiento de turnos
        /// </summary>
        /// <param name="pMetodoDeOrdenamiento">Metodo de ordenamiento que utilizara la cola de turnos de la sala</param>
        public SalaDeHospital(MetodoDeOrdenamiento pMetodoDeOrdenamiento)
        {
            iMetodoDeOrdenamiento = pMetodoDeOrdenamiento;
        }
        /// <summary>
        /// Agrega un turno a la cola de turnos de la sala
        /// </summary>
        /// <param name="pTurno">Turno a agregar</param>
        public void AgregarTurno(Turno pTurno)
        {
            iMetodoDeOrdenamiento.AgregarTurno(iColaDeTurnos, pTurno);
        }
        /// <summary>
        /// Devuelve el siguiente turno en la cola
        /// </summary>
        /// <returns></returns>
        public Turno SiguienteTurno()
        {
            return iMetodoDeOrdenamiento.SiguienteTurno(iColaDeTurnos);
        }
        /// <summary>
        /// Devuelve la cantidad de turnos en la cola
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeTurnos()
        {
            return iColaDeTurnos.Count;
        }
        /// <summary>
        /// Establece un metodo de ordenamiento para la cola
        /// </summary>
        /// <param name="pMetodoDeOrdenamiento">Nuevo metodo de ordenamiento</param>
        public void SetMetodoDeOrdenamiento(MetodoDeOrdenamiento pMetodoDeOrdenamiento)
        {
            iMetodoDeOrdenamiento = pMetodoDeOrdenamiento;
            iMetodoDeOrdenamiento.OrdenarColaDeTurnos(iColaDeTurnos);
        }
    }
}
