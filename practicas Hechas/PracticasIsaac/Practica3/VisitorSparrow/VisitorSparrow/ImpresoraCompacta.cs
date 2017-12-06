using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace VisitorSparrow
{
    /// <summary>
    /// Clase impresora compacta. Permite imprimir de forma compacta un sistema de ficheros
    /// </summary>
    public class ImpresoraCompacta : Impresora
    {
        //nivel de anidamiento dentro del sistema de ficheros
        private int nivelAnidamiento = 0;

        /// <summary>
        /// Metodo que permite tabular los elementos del sistema de ficheros en funcion de su nivel
        /// de anidamiento
        /// </summary>
        /// <param name="nivelAnidamiento"></param>
        /// <returns> string con los espacios necesarios para tabular el elemento actual </returns>
        private String anadirTabuladores(int nivelAnidamiento)
        {
            String str = "";
            for (int i = 0; i < nivelAnidamiento; i++)
            {
                str = str + "   ";
            }
            return str;
        } //anadirTabuladores

        /// <summary>
        /// Metodo que permite imprimir un archivo
        /// </summary>
        /// <param name="archivo">archivo a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo</returns>
        public override string imprimirArchivo(Archivo archivo)
        {
            return "f " + archivo.Nombre + "\n";
        } //imprimirArchivo

        /// <summary>
        /// Metodo que permite imprimir un archivo comprimido
        /// </summary>
        /// <param name="comprimido">archivo comprimido a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo comprimido</returns>
        public override string imprimirArchivoComprimido(ArchivoComprimido comprimido)
        {
            return "c " + comprimido.Nombre + "\n";
        } //imprimirArchivoComprimido

        /// <summary>
        /// Metodo que permite imprimir un directorio
        /// </summary>
        /// <param name="directorio">directorio a imprimir</param>
        /// <returns>String conteniendo la impresion del directorio</returns>
        public override string imprimirDirectorio(Directorio directorio)
        {
            String str = "d " + directorio.Nombre + "\n";
            nivelAnidamiento++;
            foreach (ElementoSistemaFicheros e in directorio.obtenerElementos())
            {
                str = str + anadirTabuladores(nivelAnidamiento) + e.accept(this);
            }
            nivelAnidamiento--;
            return str;
        } //imprimirDirectorio

        /// <summary>
        /// Metodo que permite imprimir un enlace directo
        /// </summary>
        /// <param name="enlace">enlace directo a imprimir</param>
        /// <returns>String conteniendo la impresion del enlace directo</returns>
        public override string imprimirEnlace(EnlaceDirecto enlace)
        {
            return "e " + enlace.Nombre + "\n";
        } //imprimirEnlace
    } //ImpresoraCompacta
}
