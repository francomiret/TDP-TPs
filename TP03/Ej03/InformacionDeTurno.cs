using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    public class InformacionDeTurno
    {
        private readonly string iNombrePaciente, iDescripcion;
        /// <summary>
        /// Crea un nuevo paquete con la informacion de un turno
        /// </summary>
        /// <param name="pTurno"></param>
        public InformacionDeTurno(Turno pTurno)
        {
            iNombrePaciente = pTurno.ObtenerNombrePaciente;
            iDescripcion = pTurno.ObtenerDescripcion;
        }
        /// <summary>
        /// Devuelve el nombre del paciente
        /// </summary>
        public string ObtenerNombreDePaciente => iNombrePaciente;
        /// <summary>
        /// Devuelve la descripcion del turno
        /// </summary>
        public string ObtenerDescripcion => iDescripcion;
    }
}
