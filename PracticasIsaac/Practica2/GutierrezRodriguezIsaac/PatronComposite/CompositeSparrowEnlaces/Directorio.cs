using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Isaac Gutierrez Rodriguez
namespace CompositeSparrowEnlaces
{
    /// <summary>
    /// Directorio del sistema de ficheros
    /// </summary>
    public class Directorio : ElementoSistemaFicheros, IContenedor, IEnlazable
    {
        //tamanyo derivado de la definicion de un nuevo directorio
        private const int tamanyoDefinicion = 1; //KB

        /// <summary>
        /// Constructor de la clase Directorio
        /// </summary>
        /// <param name="nombre"> nombre del directorio </param>
        public Directorio(String nombre) : base(nombre) { }

        

        /// <summary>
        /// Metodo que calcula el tamanyo del directorio
        /// </summary>
        /// <returns> tamanyo del directorio </returns>
        public override double calcularTamanyo()
        {
            double tamanyo = tamanyoDefinicion;

            //se anyade el tamanyo de los elementos contenidos
            foreach (ElementoSistemaFicheros e in Archivos)
            {
                tamanyo += e.calcularTamanyo();
            }

            return tamanyo;
        }

        /// <summary>
        /// Metodo que permite anyadir elementos al directorio
        /// </summary>
        /// <param name="elemento"> elemento a anyadir </param>
        public virtual void anadeElemento(ElementoSistemaFicheros elemento)
        {
            Archivos.Add(elemento);
        }

        /// <summary>
        /// Metodo que permite eliminar elementos del directorio
        /// </summary>
        /// <param name="elemento"> elemento a eliminar </param>
        public virtual void eliminaElemento(ElementoSistemaFicheros e)
        {
            Archivos.Remove(e);
        }

        /// <summary>
        /// Metodo que devuelve el numero de archivos contenidos en el directorio
        /// </summary>
        /// <returns> numero de archivos contenidos en el directorio </returns>
        public override int numArchivos()
        {
            int numArchivos = 0;

            foreach (ElementoSistemaFicheros e in Archivos)
            {
                numArchivos += e.numArchivos();
            }

            return numArchivos;
        }
    }
}
