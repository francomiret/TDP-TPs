using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03Nuevo
{
    public class RepositorioPalabra
    {
        private string[] bdd = new string[30];

        public RepositorioPalabra()
        {
            bdd[0] = "paralelepipedo";
            bdd[1] = "auto";
            bdd[2] = "moto";
            bdd[3] = "chinela";
            bdd[4] = "antropologo";
            bdd[5] = "oxidado";
            bdd[6] = "avatar";
            bdd[7] = "laptop";
            bdd[8] = "hola";
            bdd[9] = "celular";
            bdd[10] = "celulitis";
            bdd[11] = "epidemia";
            bdd[12] = "ulcera";
            bdd[13] = "organizacion";
            bdd[14] = "correlacion";
            bdd[15] = "jefe";
            bdd[16] = "censura";
            bdd[17] = "oftalmologo";
            bdd[18] = "titanic";
            bdd[19] = "parlante";
            bdd[19] = "ladron";
            bdd[20] = "abismo";
            bdd[21] = "retraso";
            bdd[22] = "callejon";
            bdd[23] = "exportar";
            bdd[24] = "dilexia";
            bdd[25] = "desarrollo";
            bdd[26] = "sol";
            bdd[27] = "verano";
            bdd[28] = "cienpies";
            bdd[29] = "gangrena";
            
        }

        /// <summary>
        /// ESTE METODO SELECCIONA UNA PALABRA ALEATORIA DEL REPOSITORIO
        /// </summary>
        /// <returns></returns>
        public string SeleccionPalabra()
        {
            Random r = new Random();
            int aleatorio = r.Next(0, 29);
            return this.bdd[aleatorio];
        }

        

    }
}
