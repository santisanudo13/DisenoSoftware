﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Isaac Gutierrez Rodriguez
namespace CompositeSparrow
{
    /// <summary>
    /// Clase raiz dentro del patron Composite. Representa un elemento del sistema de ficheros sparrow.
    /// </summary>
    public abstract class ElementoSistemaFicheros
    {
        //nombre del elemento
        private String nombre;

        /// <summary>
        /// Propiedad nombre
        /// </summary>
        public String Nombre
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

    }
}
