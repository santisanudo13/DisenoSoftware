using System;
using AbstractFactorySparrow.Estrategias;
using AbstractFactorySparrow.SistemaFicheros;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrow.Impresoras
{
    /// <summary>
    /// Clase impresora extendida. Permite imprimir de forma extendida un sistema de ficheros
    /// </summary>
    public class ImpresoraExtendida : Impresora
    {
        //nivel de anidamiento dentro del sistema de ficheros
        private int nivelAnidamiento = 0;

        /// <summary>
        /// Constructor de la clase ImpresoraExtendida
        /// </summary>
        /// <param name="estrategia"> estrategia de visualizacion a utilizar </param>
        public ImpresoraExtendida(Visualizacion estrategia) : base(estrategia) { }

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
            return Estrategia.visualizacion(str);
        }

        /// <summary>
        /// Metodo que permite imprimir un archivo
        /// </summary>
        /// <param name="archivo">archivo a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo</returns>
        public override string imprimirArchivo(Archivo archivo)
        {
            return Estrategia.visualizacion("f " + archivo.Nombre + "\n");
        }

        /// <summary>
        /// Metodo que permite imprimir un archivo comprimido
        /// </summary>
        /// <param name="comprimido">archivo comprimido a imprimir</param>
        /// <returns>String conteniendo la impresion del archivo comprimido</returns>
        public override string imprimirArchivoComprimido(ArchivoComprimido comprimido)
        {
            String str= "c " + comprimido.Nombre + "\n";
            nivelAnidamiento++;
            foreach (ElementoSistemaFicheros e in comprimido.obtenerElementos())
            {
                str = str + anadirTabuladores(nivelAnidamiento) + e.accept(this);
            }
            nivelAnidamiento--;
            return Estrategia.visualizacion(str);
        }

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
            return Estrategia.visualizacion(str);
        }

        /// <summary>
        /// Metodo que permite imprimir un enlace directo
        /// </summary>
        /// <param name="enlace">enlace directo a imprimir</param>
        /// <returns>String conteniendo la impresion del enlace directo</returns>
        public override string imprimirEnlace(EnlaceDirecto enlace)
        {
            return Estrategia.visualizacion("e " + enlace.Nombre + "\n");
        }
    }
}
