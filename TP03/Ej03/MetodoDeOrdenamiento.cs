using System.Collections.Generic;

namespace Ej03
{
    public abstract class MetodoDeOrdenamiento
    {
        /// <summary>
        /// Agrega un turno a una lista utilizando el ordenamiento correspondiente
        /// </summary>
        /// <param name="pLista">Lista de Turnos</param>
        /// <param name="pTurno">Turno a agregar a la Lista</param>
        public abstract void AgregarTurno(List<Turno> pLista, Turno pTurno);
        /// <summary>
        /// Devuelve el siguiente turno en la lista
        /// </summary>
        /// <param name="pLista">Lista de la que se desea obtener el turno</param>
        /// <returns></returns>
        public Turno SiguienteTurno(List<Turno> pLista)
        {
            Turno pTurno = pLista[0];
            pLista.RemoveAt(0);
            return pTurno;
        }
        /// <summary>
        /// Ordena una lista segun el ordenamiento correspondiente
        /// </summary>
        /// <param name="pLista">Lista de Turnos a ordenar</param>
        public abstract List<Turno> OrdenarColaDeTurnos(List<Turno> pLista);
    }
}