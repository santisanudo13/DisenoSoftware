using Pr_06_Observer;
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
            set { this.nombre = value;
                NotificarObservers();
            }
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


        // Comprobamos si el observer se encuentra en la lista. En caso contrario,
        // lo incluye en la lista
        public void RegistrarObserver(IObserver o)
        {
            if (!observers.Contains(o))
                observers.Add(o);
        }

        // Comprobamos si el observer se encuentra en la lista. En caso afirmativo,
        // lo elimina de la lista
        public void EliminarObserver(IObserver o)
        {
            if (observers.Contains(o))
                observers.Remove(o);
        }

        // Recorre la lista de observers e invoca su metodo Update()
        public void NotificarObservers()
        {
            // Creamos un array con el estado del Subject
            String name = Nombre;

            // Recorremos todos los objetos suscritos (observers)
            IObserver observer;
            foreach (Object o in observers)
            {
                // Invocamos el metodo Update de cada observer, pasandole el array con el estado
                // del subject como parametro.
                // Cada observer ya hara lo que estime necesario con esa informacion.
                observer = (IObserver)o;
                observer.update(name);
            }
        }
    }
}
