using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSparrowEnlaces
{
    /// <summary>
    /// Archivo 
    /// </summary>
    public class Archivo : ElementoSistemaFicheros, IEnlazable
    {
        //tamanyo del archivo
        private double tamanyo; //KB
        private const int numeroArchivos = 1;

        /// <summary>
        /// Constructor de la clase Archivo
        /// </summary>
        /// <param name="nombre"> nombre del archivo </param>
        /// <param name="tamanyo"> tamanyo del archivo en KB </param>
        public Archivo(String nombre, double tamanyo) : base(nombre)
        {
            this.tamanyo = tamanyo;
        }

        /// <summary>
        /// Muestra el calculo resultante para obtener el tamanyo
        /// </summary>
        /// <returns> tamanyo del archivo </returns>
        public override double calcularTamanyo()
        {
            return tamanyo;
        }

        /// <summary>
        /// Muestra el numero de archivos que contiene, en caso
        /// de no contener, retorna 1.
        /// </summary>
        /// <returns> numero de archivos, esto es, 1 </returns>
        public override int numArchivos()
        {
            return numeroArchivos;
        }
    }
}
