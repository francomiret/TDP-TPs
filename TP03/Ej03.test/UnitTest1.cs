using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Ej03;

namespace Ej03.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Turno_SinDefinirNivel()
        {
            string iNombre = "Facundo", iDescripcion = "Quiere saber los horarios del Dr. Rodriguez";
            Turno iTurno = new Turno(iNombre, iDescripcion);
            Thread.Sleep(1000);

            bool nombreOk = iTurno.ObtenerNombrePaciente == iNombre,
                 descripcionOk = iTurno.ObtenerDescripcion == iDescripcion,
                 nivelOk = iTurno.ObtenerNivel == 5,
                 fechaYHoraOk = iTurno.ObtenerEdadEnMilisegundos > 0;

            Assert.IsTrue(nombreOk && descripcionOk && nivelOk && fechaYHoraOk);
        }
        [TestMethod]
        public void Test_Turno_DefiniendoNivel()
        {
            string iNombre = "Facundo", iDescripcion = "Quiere saber los horarios del Dr. Rodriguez";
            int iNivel = 3;
            Turno iTurno = new Turno(iNombre, iDescripcion, iNivel);
            Thread.Sleep(1000);

            bool nombreOk = iTurno.ObtenerNombrePaciente == iNombre,
                 descripcionOk = iTurno.ObtenerDescripcion == iDescripcion,
                 nivelOk = iTurno.ObtenerNivel == iNivel,
                 edadOk = iTurno.ObtenerEdadEnMilisegundos > 0;

            //Console.WriteLine(nombreOk.ToString()+descripcionOk.ToString()+nivelOk.ToString()+edadOk.ToString());
            //Console.ReadKey();

            Assert.IsTrue(nombreOk && descripcionOk && nivelOk && edadOk);
        }
        [TestMethod]
        public void Test_Turno_ModificandoNivel()
        {
            string iNombre = "Facundo", iDescripcion = "Quiere saber los horarios del Dr. Rodriguez";
            int iNivelInicial = 3, iNivelFinal = 2;
            Turno iTurno = new Turno(iNombre, iDescripcion, iNivelInicial);
            Thread.Sleep(1000);
            iTurno.ModificarNivel(iNivelFinal);

            bool nombreOk = iTurno.ObtenerNombrePaciente == iNombre,
                 descripcionOk = iTurno.ObtenerDescripcion == iDescripcion,
                 nivelOk = iTurno.ObtenerNivel == iNivelFinal,
                 fechaYHoraOk = iTurno.ObtenerEdadEnMilisegundos > 0;

            Assert.IsTrue(nombreOk && descripcionOk && nivelOk && fechaYHoraOk);
        }
        [TestMethod]
        public void Test_InformacionDeTurno()
        {
            string iNombre = "Facundo", iDescripcion = "Quiere saber los horarios del Dr. Rodriguez";
            Turno iTurno = new Turno(iNombre, iDescripcion);
            InformacionDeTurno iInfoDeTurno = new InformacionDeTurno(iTurno);

            bool nombreOk = iInfoDeTurno.ObtenerNombreDePaciente == iNombre,
                 descripcionOk = iInfoDeTurno.ObtenerDescripcion == iDescripcion;

            Assert.IsTrue(nombreOk && descripcionOk);
        }
        [TestMethod]
        public void Test_OrdenamientoFIFO()
        {
            string iNombreA = "A", iNombreB = "B", iNombreC = "C", iDescripcion = "";
            Turno iTurnoA = new Turno(iNombreA, iDescripcion),
                  iTurnoB = new Turno(iNombreB, iDescripcion),
                  iTurnoC = new Turno(iNombreC, iDescripcion);
            List<Turno> iLista = new List<Turno>();
            MetodoDeOrdenamiento iMetodoFIFO = new OrdenamientoFIFO();

            iMetodoFIFO.AgregarTurno(iLista, iTurnoA);
            iMetodoFIFO.AgregarTurno(iLista, iTurnoB);
            iMetodoFIFO.AgregarTurno(iLista, iTurnoC);

            bool Aok = iMetodoFIFO.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoA.ObtenerNombrePaciente,
                 Bok = iMetodoFIFO.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoB.ObtenerNombrePaciente,
                 Cok = iMetodoFIFO.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoC.ObtenerNombrePaciente;

            Assert.IsTrue(Aok && Bok && Cok);
        }
        [TestMethod]
        public void Test_OrdenamientoFIFO_Reordenando()
        {
            string iNombreA = "A", iNombreB = "B", iNombreC = "C", iDescripcion = "";
            Turno iTurnoA = new Turno(iNombreA, iDescripcion);
            Thread.Sleep(50);
            Turno iTurnoB = new Turno(iNombreB, iDescripcion);
            Thread.Sleep(50);
            Turno iTurnoC = new Turno(iNombreC, iDescripcion);
            Thread.Sleep(50);
            List<Turno> iLista = new List<Turno>();
            MetodoDeOrdenamiento iMetodoFIFO = new OrdenamientoFIFO();

            iMetodoFIFO.AgregarTurno(iLista, iTurnoC);
            iMetodoFIFO.AgregarTurno(iLista, iTurnoA);
            iMetodoFIFO.AgregarTurno(iLista, iTurnoB);

            iLista = iMetodoFIFO.OrdenarColaDeTurnos(iLista);

            bool Aok = iMetodoFIFO.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoA.ObtenerNombrePaciente,
                 Bok = iMetodoFIFO.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoB.ObtenerNombrePaciente,
                 Cok = iMetodoFIFO.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoC.ObtenerNombrePaciente;

            Assert.IsTrue(Aok && Bok && Cok);
        }
        [TestMethod]
        public void Test_OrdenamientoTriaje()
        {
            string iNombreA = "A", iNombreB = "B", iNombreC = "C", iNombreD = "D", iDescripcion = "";
            int iNivelA = 1, iNivelB = 3, iNivelC = 3, iNivelD = 5;
            Turno iTurnoA = new Turno(iNombreA, iDescripcion, iNivelA),
                  iTurnoB = new Turno(iNombreB, iDescripcion, iNivelB);
            Thread.Sleep(50);
            Turno iTurnoC = new Turno(iNombreC, iDescripcion, iNivelC),
                  iTurnoD = new Turno(iNombreD, iDescripcion, iNivelD);
            List<Turno> iLista = new List<Turno>();
            MetodoDeOrdenamiento iMetodoTriaje = new OrdenamientoTriaje();

            iMetodoTriaje.AgregarTurno(iLista, iTurnoB);
            iMetodoTriaje.AgregarTurno(iLista, iTurnoD);
            iMetodoTriaje.AgregarTurno(iLista, iTurnoA);
            iMetodoTriaje.AgregarTurno(iLista, iTurnoC);

            bool Aok = iMetodoTriaje.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoA.ObtenerNombrePaciente,
                 Bok = iMetodoTriaje.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoB.ObtenerNombrePaciente,
                 Cok = iMetodoTriaje.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoC.ObtenerNombrePaciente,
                 Dok = iMetodoTriaje.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoD.ObtenerNombrePaciente;

            Assert.IsTrue(Aok && Bok && Cok && Dok);
        }
        [TestMethod]
        public void Test_OrdenamientoTriaje_Reordenando()
        {
            string iNombreA = "A", iNombreB = "B", iNombreC = "C", iNombreD = "D", iDescripcion = "";
            int iNivelA = 1, iNivelB = 3, iNivelC = 3, iNivelD = 5;
            Turno iTurnoA = new Turno(iNombreA, iDescripcion, iNivelA),
                  iTurnoB = new Turno(iNombreB, iDescripcion, iNivelB);
            Thread.Sleep(50);
            Turno iTurnoC = new Turno(iNombreC, iDescripcion, iNivelC),
                  iTurnoD = new Turno(iNombreD, iDescripcion, iNivelD);
            List<Turno> iLista = new List<Turno>();
            MetodoDeOrdenamiento iMetodoTriaje = new OrdenamientoTriaje();

            iLista.Add(iTurnoB);
            iLista.Add(iTurnoD);
            iLista.Add(iTurnoA);
            iLista.Add(iTurnoC);
            iLista = iMetodoTriaje.OrdenarColaDeTurnos(iLista);

            bool Aok = iMetodoTriaje.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoA.ObtenerNombrePaciente,
                 Bok = iMetodoTriaje.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoB.ObtenerNombrePaciente,
                 Cok = iMetodoTriaje.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoC.ObtenerNombrePaciente,
                 Dok = iMetodoTriaje.SiguienteTurno(iLista).ObtenerNombrePaciente == iTurnoD.ObtenerNombrePaciente;

            Assert.IsTrue(Aok && Bok && Cok && Dok);
        }
    }
}
