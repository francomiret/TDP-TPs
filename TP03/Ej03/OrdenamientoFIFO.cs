using System.Collections.Generic;
using System.Linq;
using System;

namespace Ej03
{
    public class OrdenamientoFIFO : MetodoDeOrdenamiento
    {
        /// <summary>
        /// Agrega un turno a una lista utilizando el ordenamiento FIFO
        /// </summary>
        /// <param name="pLista">Lista de Turnos</param>
        /// <param name="pTurno">Turno a agregar a la Lista</param>
        public override void AgregarTurno(List<Turno> pLista, Turno pTurno)
        {
            pLista.Add(pTurno);
        }
        /// <summary>
        /// Ordena la lista por hora de creacion del turno
        /// </summary>
        /// <param name="pLista">Lista de turnos a ordenar</param>
        public override List<Turno> OrdenarColaDeTurnos(List<Turno> pLista)
        {
            return pLista.OrderByDescending(x => x.ObtenerEdadEnMilisegundos).ToList();
        }
    }
}