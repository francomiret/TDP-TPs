using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class Circulo
    {
        
            private double iRadio;
            private Punto iCentro;

            
            
        
            

            public  Circulo(Punto pCentro, double pRadio)
            {
            this.iRadio = pRadio;
            this.iCentro = pCentro;

            }

            public Circulo(double pX, double pY, double pRadio)
            {
            this.iRadio = pRadio;
            this.iCentro = new Punto(pX, pY);


            }
            public Punto Centro
            {
                get { return this.iCentro; }
            }

            public double Radio
            {

                get { return this.iRadio; }
            }

            /// <summary>
            /// ESTE METODO CALCULA EL AREA
            /// </summary>
            /// <returns></returns> DEVUELVE EL VALOR DEL AREA DEL CIRCULO
            public double Area()
            {
            double res = (Math.PI) * (Math.Pow(this.iRadio,2));
            return res;
            }
            
            /// <summary>
            /// ESTE METODO CALCULA EL PERIMETRO
            /// </summary>
            /// <returns></returns> DEVUELVE EL VALOR DEL PERIMETRO DEL CIRCULO
            public double Perimetro()
            {
                double res = (Math.PI) * this.iRadio*2;
                return res;
            }

    }
}
