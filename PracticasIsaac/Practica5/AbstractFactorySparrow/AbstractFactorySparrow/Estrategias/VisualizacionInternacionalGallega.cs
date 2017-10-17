using System;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrow.Estrategias
{
    /// <summary>
    /// Visualizacion: Estrategia Internacional Gallega
    /// </summary>
    public class VisualizacionInternacionalGallega : Visualizacion
    {
        private const String stringReemplazo = "nh";

        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para la estrategia internacional gallega
        /// </summary>
        /// <param name="str"> string conteniendo el sistema de ficheros a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia internacional gallega </returns>
        public override String visualizacion(String str)
        {
            str = str.Replace("ñ", stringReemplazo);
            str = str.Replace("á", "a");
            str = str.Replace("ú", "u");
            str = str.Replace("í", "i");
            str = str.Replace("ó", "o");
            str = str.Replace("é", "e");
            str = str.Replace("Ñ", "Nh");
            str = str.Replace("Á", "A");
            str = str.Replace("Ú", "U");
            str = str.Replace("Í", "I");
            str = str.Replace("Ó", "O");
            str = str.Replace("É", "E");

            return str;
        }
    }
}
