using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Isaac Gutierrez Rodriguez
namespace CompositeSparrowEnlaces
{
    /// <summary>
    /// Clase raiz dentro del patron Composite. Representa un elemento del sistema de ficheros sparrow.
    /// </summary>
    public abstract class ElementoSistemaFicheros
    {
        private String nombre;
        private ISet<ElementoSistemaFicheros> archivos = new HashSet<ElementoSistemaFicheros>();

        private IList<IObserver> observers = new List<IObserver>();
        /// <summary>
        /// Propiedad nombre
        /// </summary>
        public virtual String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public ISet<ElementoSistemaFicheros> Archivos
        {
            get { return this.archivos; }
            set { this.archivos = value; }
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

    }
}
