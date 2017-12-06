using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace VisitorSparrow
{
    /// <summary>
    /// Clase abstracta impresora. Define los metodos que permiten visualizar un sistema de ficheros
    /// </summary>
    public abstract class Impresora
    {
        /// <summary>
        /// Metodo que permite imprimir un archivo
        /// </summary>
        /// <param name="archivo">archivo a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo</returns>
        public abstract String imprimirArchivo(Archivo archivo);

        /// <summary>
        /// Metodo que permite imprimir un archivo comprimido
        /// </summary>
        /// <param name="comprimido">archivo comprimido a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo comprimido</returns>
        public abstract String imprimirArchivoComprimido(ArchivoComprimido comprimido);

        /// <summary>
        /// Metodo que permite imprimir un directorio
        /// </summary>
        /// <param name="directorio">directorio a imprimir</param>
        /// <returns>String conteniendo la impresion del directorio</returns>
        public abstract String imprimirDirectorio(Directorio directorio);

        /// <summary>
        /// Metodo que permite imprimir un enlace directo
        /// </summary>
        /// <param name="enlace">enlace directo a imprimir</param>
        /// <returns>String conteniendo la impresion del enlace directo</returns>
        public abstract String imprimirEnlace(EnlaceDirecto enlace);
    } //Impresora
}
