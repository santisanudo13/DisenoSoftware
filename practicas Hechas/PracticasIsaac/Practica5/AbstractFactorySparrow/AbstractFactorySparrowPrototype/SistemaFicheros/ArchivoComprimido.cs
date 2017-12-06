using System;
using AbstractFactorySparrowPrototype.Impresoras;
using System.Collections.Generic;
using System.Linq;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowPrototype.SistemaFicheros
{
    /// <summary>
    /// Archivo Comprimido
    /// </summary>
    public class ArchivoComprimido : ElementoSistemaFicheros, IContenedor, IEnlazable
    {
        //factor de compresion. En el caso del sistema de ficheros sparrow es un factor constante del 0.30
        private const double factorCompresion = 0.30;

        private const int numeroArchivos = 1;

        //Elementos contenidos en el archivo comprimido
        ISet<ElementoSistemaFicheros> coleccionElementos = new HashSet<ElementoSistemaFicheros>();

        /// <summary>
        /// Constructor de la clase ArchivoComprimido
        /// </summary>
        /// <param name="nombre"> nombre del archivo comprimido </param>
        public ArchivoComprimido(string nombre) : base(nombre) { }

        /// <summary>
        /// Metodo que calcula el tamanyo del archivo comprimido
        /// </summary>
        /// <returns></returns>
        public override double calcularTamanyo()
        {
            double tamanyo = 0;

            //se anyade el tamanyo de los ficheros contenidos
            foreach (ElementoSistemaFicheros e in coleccionElementos)
            {
                tamanyo += e.calcularTamanyo();
            }

            //se aplica el factor de compresion
            return tamanyo * (1 - factorCompresion);
        }

        /// <summary>
        /// Metodo que permite anyadir elementos al archivo comprimido
        /// </summary>
        /// <param name="elemento"> elemento a anyadir </param>
        public virtual void anadeElemento(ElementoSistemaFicheros elemento)
        {
            coleccionElementos.Add(elemento);
        }

        /// <summary>
        /// Metodo que permite eliminar elementos del archivo comprimido
        /// </summary>
        /// <param name="elemento"> elemento a eliminar </param>
        public virtual void eliminaElemento(ElementoSistemaFicheros e)
        {
            coleccionElementos.Remove(e);
        }
        /// <summary>
        /// Metodo que permite obtener los elementos contenidos por el archivo comprimido
        /// </summary>
        /// <returns> lista con los elementos contenidos por el archivo comprimido </returns>
        public List<ElementoSistemaFicheros> obtenerElementos()
        {
            return this.coleccionElementos.ToList();
        }

        /// <summary>
        /// Metodo que devuelve el numero de archivos contenidos en el archivo comprimido. Los archivos
        /// comprimidos se cuentan como un unico elemento, sin tener en cuenta cuantos elementos contienen.
        /// </summary>
        /// <returns> numero de archivos, en este caso 1 </returns>
        public override int numArchivos()
        {
            return numeroArchivos;
        }

        /// <summary>
        /// Metodo que retorna el String que contiene la impresion del archivo comprimido
        /// </summary>
        /// <param name="impresora"> impresora concreta para imprimir el archivo comprimido </param>
        /// <returns> impresion del archivo comprimido </returns>
        public override String accept(Impresora impresora)
        {
            return impresora.imprimirArchivoComprimido(this);
        } 
    }
}
