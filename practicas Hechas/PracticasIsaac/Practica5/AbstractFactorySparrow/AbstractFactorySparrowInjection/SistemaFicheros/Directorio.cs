using System;
using System.Collections.Generic;
using System.Linq;
using AbstractFactorySparrowInjection.Impresoras;


namespace AbstractFactorySparrowInjection.SistemaFicheros
{
    /// <summary>
    /// Directorio del sistema de ficheros
    /// </summary>
    public class Directorio : ElementoSistemaFicheros, IContenedor, IEnlazable
    {
        //tamanyo derivado de la declaracion de un nuevo directorio
        private const int tamanyoDeclaracion = 1; //KB

        /// <summary>
        /// Constructor de la clase Directorio
        /// </summary>
        /// <param name="nombre"> nombre del directorio </param>
        public Directorio(String nombre) : base(nombre) { }

        //conjunto de elementos contenidos en el directorio
        private ISet<ElementoSistemaFicheros> coleccionElementos = new HashSet<ElementoSistemaFicheros>();

        /// <summary>
        /// Metodo que calcula el tamanyo del directorio
        /// </summary>
        /// <returns> tamanyo del directorio </returns>
        public override double calcularTamanyo()
        {
            double tamanyo = tamanyoDeclaracion;

            //se anyade el tamanyo de los ficheros contenidos
            foreach (ElementoSistemaFicheros e in coleccionElementos)
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
            coleccionElementos.Add(elemento);
        }

        /// <summary>
        /// Metodo que permite eliminar elementos del directorio
        /// </summary>
        /// <param name="elemento"> elemento a eliminar </param>
        public virtual void eliminaElemento(ElementoSistemaFicheros e)
        {
            coleccionElementos.Remove(e);
        }

        /// <summary>
        /// Metodo que permite obtener los elementos contenidos por el directorio
        /// </summary>
        /// <returns> lista con los elementos contenidos por el directorio </returns>
        public List<ElementoSistemaFicheros> obtenerElementos()
        {
            return this.coleccionElementos.ToList();
        }

        /// <summary>
        /// Metodo que devuelve el numero de archivos contenidos en el directorio
        /// </summary>
        /// <returns> numero de archivos contenidos en el directorio </returns>
        public override int numArchivos()
        {
            int numArchivos = 0;

            foreach (ElementoSistemaFicheros e in coleccionElementos)
            {
                numArchivos += e.numArchivos();
            }

            return numArchivos;
        }

        /// <summary>
        /// Metodo que retorna el String que contiene la impresion del directorio
        /// </summary>
        /// <param name="impresora"> impresora concreta para imprimir el directorio </param>
        /// <returns> impresion del directorio </returns>
        public override String accept(Impresora impresora)
        {
            return impresora.imprimirDirectorio(this);
        }

    }
}
