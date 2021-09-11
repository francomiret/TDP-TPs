using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class RepositorioBanca
    {   
        private Banca[] vec = new Banca[100];

        /// <summary>
        /// ESTE METODO AGREGA UNA BANCA AL REPOSITORIO
        /// </summary>
        /// <param name="pBanca"></param> CORRESPONDE A LA BANCA A AGREGAR
        /// <returns></returns> DEVUELVE EL ESTADO DE LA OPERACION
        public bool Agregar(Banca pBanca)
        {
            int tam = vec.Length;
            bool creo = false;
            int i = 0;
            while ((i<tam)&&(creo!=true))
            {     
               if (vec[i] == null)
               {
                    vec[i] = pBanca;
                    creo = true;
               }
                i++;
            }
            return creo;                     
        }

        /// <summary>
        /// ESTE METODO BUSCA UNA BANCA
        /// </summary>
        /// <param name="pNumero"></param> CORRESPONDE AL NUMERO DE BANCA
        /// <returns></returns> DEVUELVE AL BANCA CORRESPONDIENTE 
        public Banca Obtener(string pNumero)
        {
            int tam = this.vec.Length;
            
            for (int i = 0; i<tam;i++)
            {
                if ((this.vec[i] !=null)&&(this.vec[i].Numero == pNumero))
                {
                   return this.vec[i];
                }                    
            }
            return null;
        }
    }
}
