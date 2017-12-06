using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySparrowLambda
{
    /// <summary>
    /// Clase impresora extendida. Permite imprimir de forma extendida un sistema de ficheros
    /// </summary>
    public class ImpresoraExtendida : Impresora
    {
        //nivel de anidamiento dentro del sistema de ficheros
        private int nivelAnidamiento = 0;

        /// <summary>
        /// Metodo que permite tabular los elementos del sistema de ficheros en funcion de su nivel
        /// de anidamiento
        /// </summary>
        /// <param name="nivelAnidamiento"></param>
        /// <returns></returns>
        private String anadirTabuladores(int nivelAnidamiento)
        {
            String str = "";
            for(int i = 0; i < nivelAnidamiento; i++)
            {
                str = str + "   ";
            }
            return str;
        }

        /// <summary>
        /// Metodo que permite imprimir un archivo
        /// </summary>
        /// <param name="archivo">archivo a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo</returns>
        public override string imprimirArchivo(Archivo archivo, Func<String, String> visualizacion)
        {
            return visualizacion("f " + archivo.Nombre + "\n");
        }

        
        /// <summary>
        /// Metodo que permite imprimir un archivo comprimido
        /// </summary>
        /// <param name="comprimido">archivo comprimido a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo comprimido</returns>
        public override string imprimirArchivoComprimido(ArchivoComprimido comprimido, Func<String, String> visualizacion)
        {
            String str= "c " + comprimido.Nombre + "\n";
            nivelAnidamiento++;
            foreach (ElementoSistemaFicheros e in comprimido.obtenerElementos())
            {
                str = str + anadirTabuladores(nivelAnidamiento) + e.accept(this, visualizacion);
            }
            nivelAnidamiento--;
            return visualizacion(str);
        }

        /// <summary>
        /// Metodo que permite imprimir un directorio
        /// </summary>
        /// <param name="directorio">directorio a imprimir</param>
        /// <returns>String conteniendo la impresion del directorio</returns>
        public override string imprimirDirectorio(Directorio directorio, Func<String, String> visualizacion)
        {
            String str = "d " + directorio.Nombre + "\n";
            str = visualizacion(str);
            nivelAnidamiento++;
            foreach (ElementoSistemaFicheros e in directorio.obtenerElementos())
            {
                str = str + anadirTabuladores(nivelAnidamiento) + e.accept(this, visualizacion);
            }
            nivelAnidamiento--;
            return visualizacion(str);
        }

        /// <summary>
        /// Metodo que permite imprimir un enlace directo
        /// </summary>
        /// <param name="enlace">enlace directo a imprimir</param>
        /// <returns>String conteniendo la impresion del enlace directo</returns>
        public override string imprimirEnlace(EnlaceDirecto enlace, Func<String, String> visualizacion)
        {
            return visualizacion("e " + enlace.Nombre + "\n");
        }
    }
}
