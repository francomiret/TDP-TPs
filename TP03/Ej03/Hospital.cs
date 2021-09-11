using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    public class Hospital
    {
        private SalaDeHospital iSalaDeConsultas = new SalaDeHospital(new OrdenamientoFIFO()),
                               iSalaDeUrgencias = new SalaDeHospital(new OrdenamientoTriaje());
        /// <summary>
        /// Agrega una consulta a la Sala de Consultas
        /// </summary>
        /// <param name="pNombrePaciente">String que contiene el nombre del paciente</param>
        /// <param name="pDescripcion">String que contiene la descripcion de la consulta</param>
        public void AgregarConsulta(string pNombrePaciente, string pDescripcion)
        {
            iSalaDeConsultas.AgregarTurno(new Turno(pNombrePaciente, pDescripcion));
        }
        /// <summary>
        /// Devuelve la InformacionDeTurno de la siguiente consulta en la cola de la Sala de Consultas
        /// </summary>
        /// <returns></returns>
        public InformacionDeTurno SiguienteConsulta()
        {
            return new InformacionDeTurno(iSalaDeConsultas.SiguienteTurno());
        }
        /// <summary>
        /// Devuelve la cantidad de consultas en la cola de la Sala de Consultas
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeConsultas()
        {
            return iSalaDeConsultas.ObtenerCantidadDeTurnos();
        }

        /// <summary>
        /// Agrega una consulta a la Sala de Urgencias
        /// </summary>
        /// <param name="pNombrePaciente">String que contiene el nombre del paciente</param>
        /// <param name="pDescripcion">String que contiene la descripcion de la urgencia</param>
        /// <param name="pNivelUrgencia">Integer que contiene el nivel de urgencia</param>
        public void AgregarUrgencia(string pNombrePaciente, string pDescripcion, int pNivelUrgencia)
        {
            iSalaDeUrgencias.AgregarTurno(new Turno(pNombrePaciente, pDescripcion, pNivelUrgencia));
        }
        /// <summary>
        /// Devuelve la InformacionDeTurno de la siguiente urgencia en la cola de la Sala de Urgencias
        /// </summary>
        /// <returns></returns>
        public InformacionDeTurno SiguienteUrgencia()
        {
            return new InformacionDeTurno(iSalaDeUrgencias.SiguienteTurno());
        }
        /// <summary>
        /// Devuelve la cantidad de urgencias en la cola de la Sala de Urgencias
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeUrgencias()
        {
            return iSalaDeUrgencias.ObtenerCantidadDeTurnos();
        }
        /// <summary>
        /// Cambia el ordenamiento de la cola de Urgencias a FIFO
        /// </summary>
        public void SetOrdenamientoUrgenciasFIFO()
        {
            iSalaDeUrgencias.SetMetodoDeOrdenamiento(new OrdenamientoFIFO());
        }
        /// <summary>
        /// Cambia el ordenamiento de la cola de Urgencias a Tiraje
        /// </summary>
        public void SetOrdenamientoUrgenciasTriaje()
        {
            iSalaDeUrgencias.SetMetodoDeOrdenamiento(new OrdenamientoTriaje());
        }
    }
}
