using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    public abstract class FiguraGeometrica
    {
        /// <summary>
        /// Devuelve el area de la figura
        /// </summary>
        /// <returns></returns>
        public abstract double CalcularArea();
        /// <summary>
        /// Devuelve el perimetro de la figura
        /// </summary>
        /// <returns></returns>
        public abstract double CalcularPerimetro();
    }
}
