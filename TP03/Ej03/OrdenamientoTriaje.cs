using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    public class OrdenamientoTriaje : MetodoDeOrdenamiento
    {
        /// <summary>
        /// Agrega un turno a una lista utilizando el ordenamiento triaje
        /// </summary>
        /// <param name="pLista">Lista de Turnos</param>
        /// <param name="pTurno">Turno a agregar a la Lista</param>
        public override void AgregarTurno(List<Turno> pLista, Turno pTurno)
        {
            int i = -1;
            do
            {
                i++;
            } while ((i < pLista.Count) && (pTurno.ObtenerNivel >= pLista[i].ObtenerNivel));
            pLista.Insert(i, pTurno);
        }
        /// <summary>
        /// Ordena una lista segun el ordenamiento triaje
        /// </summary>
        /// <param name="pLista">Lista de Turnos a ordenar</param>
        public override List<Turno> OrdenarColaDeTurnos(List<Turno> pLista)
        {
            return pLista.OrderByDescending(x => x.ObtenerEdadEnMilisegundos).ThenBy(x => x.ObtenerNivel).ToList();
        }
    }
}
