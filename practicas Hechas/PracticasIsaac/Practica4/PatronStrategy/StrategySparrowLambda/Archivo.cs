using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySparrowLambda
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
        /// <param name="tamanyo"> tamanyo del archivo (en KB) </param>
        public Archivo(String nombre, double tamanyo) : base(nombre)
        {
            this.tamanyo = tamanyo;
        }

        /// <summary>
        /// Metodo que retorna el tamanyo del archivo
        /// </summary>
        /// <returns> tamanyo del archivo </returns>
        public override double calcularTamanyo()
        {
            return tamanyo;
        }

        /// <summary>
        /// Metodo que retorna el numero de archivos. En este caso al ser un archivo no puede
        /// contener otros elementos, por lo que siempre retorna 1.
        /// </summary>
        /// <returns> numero de archivos, esto es, 1 </returns>
        public override int numArchivos()
        {
            return numeroArchivos;
        }

        /// <summary>
        /// Metodo que retorna el String que contiene la impresion del archivo
        /// </summary>
        /// <param name="impresora"> impresora concreta para imprimir el archivo </param>
        /// <returns> impresion del archivo </returns>
        public override String accept(Impresora impresora, Func<String, String> visualizacion)
        {
            return impresora.imprimirArchivo(this,visualizacion);
        }
    }
}
