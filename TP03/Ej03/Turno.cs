using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    public class Turno
    {
        private readonly string iNombre, iDescripcion;
        private int iNivel;
        private readonly DateTime iFechaYHoraDeCreacion;
        /// <summary>
        /// Genera un nuevo turno
        /// </summary>
        /// <param name="pNombre">String que contiene el nombre del paciente</param>
        /// <param name="pDescripcion">String que contiene la descripcion del problema</param>
        public Turno(string pNombre, string pDescripcion)
        {
            iNombre = pNombre;
            iDescripcion = pDescripcion;
            iNivel = 5;
            iFechaYHoraDeCreacion = DateTime.Now;
        }
        /// <summary>
        /// Genera un nuevo turno
        /// </summary>
        /// <param name="pNombre">String que contiene el nombre del paciente</param>
        /// <param name="pDescripcion">String que contiene la descripcion del problema</param>
        /// <param name="pNivel">Integer que representa el nivel de urgencia</param>
        public Turno(string pNombre, string pDescripcion, int pNivel)
        {
            iNombre = pNombre;
            iDescripcion = pDescripcion;
            iNivel = pNivel;
            iFechaYHoraDeCreacion = DateTime.Now;
        }
        /// <summary>
        /// Devuelve el nombre del paciente
        /// </summary>
        /// <returns></returns>
        public string ObtenerNombrePaciente => iNombre;
        /// <summary>
        /// Devuelve la descripcion del problema
        /// </summary>
        /// <returns></returns>
        public string ObtenerDescripcion => iDescripcion;
        /// <summary>
        /// Devuelve el nivel de urgencia del turno
        /// </summary>
        /// <returns></returns>
        public int ObtenerNivel => iNivel;
        /// <summary>
        /// Modifica el nivel de urgencia del turno
        /// </summary>
        /// <param name="pNivel">Integer que representa el nuevo nivel de urgencia</param>
        public void ModificarNivel(int pNivel)
        {
            iNivel = pNivel;
        }
        /// <summary>
        /// Devuelve la edad en milisegundos del Turno
        /// </summary>
        /// <returns></returns>
        public double ObtenerEdadEnMilisegundos => DateTime.Now.Subtract(iFechaYHoraDeCreacion).TotalMilliseconds;
    }
}
