using System;
using AbstractFactorySparrowPrototype.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowPrototype.SistemaFicheros
{
    /// <summary>
    /// Enlace Directo a un elemento del sistema de ficheros
    /// </summary>
    public class EnlaceDirecto : ElementoSistemaFicheros
    {
        //tamanyo del enlace. Todos los enlaces tienen un tamanyo fijo de 1KB
        private const double tamanyo = 1; //KB
        //los enlaces no se consideran como archivos
        private const int numeroDeArchivos = 0;

        //elemento enlazado
        private IEnlazable elementoDestino;

        /// <summary>
        /// Propiedad nombre. Los enlaces tienen un nombre fijo igual al nombre del elemento enlazado
        /// por lo que este no puede modificarse
        /// </summary>
        public override String Nombre
        {
            get { return base.Nombre; }
            set { }
        }

        /// <summary>
        /// Contructor de la clase Enlace
        /// </summary>
        /// <param name="elementoDestino"> elemento enlazado </param>
        public EnlaceDirecto(IEnlazable elementoDestino) : base(elementoDestino.Nombre)
        {
            this.elementoDestino = elementoDestino;
        }

        /// <summary>
        /// Metodo para calcular el tamanyo del enlace
        /// </summary>
        /// <returns> tamanyo del enlace </returns>
        public override double calcularTamanyo()
        {
            return tamanyo;
        }

        /// <summary>
        /// Metodo para calcular el numero de archivos
        /// </summary>
        /// <returns> numero de archivos </returns>
        public override int numArchivos()
        {
            return numeroDeArchivos;
        }

        /// <summary>
        /// Metodo que retorna el String que contiene la impresion del enlace directo
        /// </summary>
        /// <param name="impresora"> impresora concreta para imprimir el enlace directo </param>
        /// <returns> impresion del enlace directo </returns>
        public override String accept(Impresora impresora)
        {
            return impresora.imprimirEnlace(this);
        }

    }
}
