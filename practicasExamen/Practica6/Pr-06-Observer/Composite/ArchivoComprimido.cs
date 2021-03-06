﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSparrowEnlaces
{
    /// <summary>
    /// Archivo Comprimido
    /// </summary>
    public class ArchivoComprimido : ElementoSistemaFicheros, IContenedor, IEnlazable
    {
        //factor de compresion. En el caso del sistema de ficheros sparrow es un factor constante del 0.30
        private const double factorCompresion = 0.30;

        private const int numeroArchivos = 1;


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
            foreach (ElementoSistemaFicheros e in Archivos)
            {
                tamanyo += e.calcularTamanyo();
            }

            //se aplica el factor de compresion
            return tamanyo * factorCompresion;
        }

        /// <summary>
        /// Metodo que permite anyadir elementos al archivo comprimido
        /// </summary>
        /// <param name="elemento"> elemento a anyadir </param>
        public virtual void anadeElemento(ElementoSistemaFicheros elemento)
        {
            Archivos.Add(elemento);
        }

        /// <summary>
        /// Metodo que permite eliminar elementos del archivo comprimido
        /// </summary>
        /// <param name="elemento"> elemento a eliminar </param>
        public virtual void eliminaElemento(ElementoSistemaFicheros e)
        {
            Archivos.Remove(e);
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
    }
}
