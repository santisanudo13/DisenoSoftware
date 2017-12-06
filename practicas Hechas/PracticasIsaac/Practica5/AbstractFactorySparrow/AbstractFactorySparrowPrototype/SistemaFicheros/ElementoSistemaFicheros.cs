using System;
using AbstractFactorySparrowPrototype.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowPrototype.SistemaFicheros
{
    /// <summary>
    /// Clase raiz dentro del patron Composite. Representa un elemento del sistema de ficheros sparrow.
    /// </summary>
    public abstract class ElementoSistemaFicheros
    {
        private String nombre;

        /// <summary>
        /// Propiedad nombre
        /// </summary>
        public virtual String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Constructor de la clase ElementoSistemaFicheros
        /// </summary>
        /// <param name="nombre">nombre del elemento a crear</param>
        public ElementoSistemaFicheros(String nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Metodo que calcula el tamanyo del elemento del sistema de ficheros
        /// </summary>
        /// <returns> tamanyo del elemento </returns>
        public abstract double calcularTamanyo();

        /// <summary>
        /// Metodo que calcula el numero de elementos contenidos por el elemento del sistema de ficheros
        /// </summary>
        /// <returns> numero de archivos contenidos por el elemento </returns>
        public abstract int numArchivos();

        /// <summary>
        /// Metodo que retorna el String que contiene la impresion del elemento
        /// </summary>
        /// <param name="impresora"> impresora concreta para imprimir el elemento </param>
        /// <returns> impresion del elemento </returns>
        public abstract String accept(Impresora impresora);

    }
}
