using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace StrategySparrow
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

            return str;
        }
    }
}
