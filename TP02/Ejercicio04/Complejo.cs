using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Complejo
    {
        private readonly double iReal;
        private readonly double iImaginario;

        public Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }

        

        public double Real
        {
            get { return this.iReal; }
        }

        public double Imaginario
        {
            get { return this.iImaginario; }
        }

        /// <summary>
        /// ESTE METODO CALULA EL ARGUMENTO EN RADIANES DEL NUMERO 
        /// </summary>
        /// <returns></returns>
        public double ArgumentoEnRadianes()
        {
            return Math.Atan2(this.iImaginario,this.iReal);           
        }

        /// <summary>
        /// ESTE METODO CALCULA EL ARGUMENTO EN GRADOS DEL NUMERO
        /// </summary>
        /// <returns></returns>
        public double ArgumentoEnGrados()
        {
            return (Math.Atan2(this.iImaginario, this.iReal))*180/Math.PI;
        }

        /// <summary>
        /// ESTE METODO DEVUELVE EL CONJUGADO DEL NUMERO
        /// </summary>
        /// <returns></returns>
        public Complejo Conjugado()
        {
            Complejo conj = new Complejo(this.iReal,-(this.iImaginario));
            return conj;
        }

        /// <summary>
        /// ESTE METODO DEVUELVE LA MAGNITUD DEL NUMERO
        /// </summary>
        /// <returns></returns>
        public double Magnitud()
        {
            return Math.Sqrt(Math.Pow(this.iReal, 2) + Math.Pow(this.iImaginario, 2));
        }


        public bool EsReal()
        {
            if (this.iImaginario==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EsImaginario()
        {
            if (this.iReal == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// ESTE METODO COMPARA DOS NUMEROS COMPLEJOS
        /// </summary>
        /// <param name="pOtroComplejo"></param>
        /// <returns></returns>
        public bool EsIgual(Complejo pOtroComplejo)
        {
            if (this.iReal == pOtroComplejo.iReal && this.iImaginario == pOtroComplejo.iImaginario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ESTE METODO COMPARA EL NUMERO COMPLEJO CON LA PARTE REAL E IMAGINARIA INGRESADA.
        /// </summary>
        /// <param name="pReal"></param>
        /// <param name="pImaginario"></param>
        /// <returns></returns>
        public bool EsIgual(double pReal, double pImaginario)
        {
            if (this.iReal == pReal && this.iImaginario == pImaginario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ESTE METODO SUMA DOS NUMEROS COMPLEJOS
        /// </summary>
        /// <param name="pOtroComplejo"></param>
        /// <returns></returns>
        public Complejo Sumar(Complejo pOtroComplejo)
        {
            Complejo compl = new Complejo(this.iReal+pOtroComplejo.iReal,this.iImaginario+pOtroComplejo.iImaginario);
            return compl;
        }

        /// <summary>
        /// ESTE METODO RESTA DOS NUMEROS COMPLEJOS
        /// </summary>
        /// <param name="pOtroComplejo"></param>
        /// <returns></returns>
        public Complejo Restar(Complejo pOtroComplejo)
        {
            Complejo compl = new Complejo(this.iReal - pOtroComplejo.iReal, this.iImaginario - pOtroComplejo.iImaginario);
            return compl;
        }

        /// <summary>
        /// ESTE METODO MULTIPLICA DOS NUMEROS COMPLEJOS
        /// </summary>
        /// <param name="pOtroComplejo"></param>
        /// <returns></returns>
        public Complejo MultiplicarPor(Complejo pOtroComplejo) // (a + bi)*(c + di) = (ac-bd) + (ad+bc)i -- (2 4)(1 1)=(2-4 
        {
            double a = this.iReal;
            double b = this.iImaginario;
            double c = pOtroComplejo.iReal;
            double d = pOtroComplejo.iImaginario;
            Complejo compl = new Complejo(a*c - b*d,a*d+b*c);
            return compl;
        }

        /// <summary>
        /// ESTE METODO DIVIDE DOS NUMEROS COMPLEJOS
        /// </summary>
        /// <param name="pOtroComplejo"></param>
        /// <returns></returns>
        public Complejo DividirPor(Complejo pOtroComplejo)
        {
            double a = this.iReal;
            double b = this.iImaginario;
            double c = pOtroComplejo.iReal;
            double d = pOtroComplejo.iImaginario;
            Complejo compl = new Complejo((a*c+b*d)/(Math.Pow(c,2)+Math.Pow(d,2)), (b * c - a * d) / (Math.Pow(c, 2) + Math.Pow(d, 2)));
            return compl;
        }
    }
}
