using System;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrow.Estrategias
{
    /// <summary>
    /// Visualizacion: Estrategia Gallega
    /// </summary>
    public class VisualizacionGallega : Visualizacion
    {
        private const String stringReemplazo = "nh";

        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para la estrategia gallega
        /// </summary>
        /// <param name="str"> string conteniendo el sistema de ficheros a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia gallega </returns>
        public override String visualizacion(String str)
        {
            str = str.Replace("ñ", stringReemplazo);
            return str.Replace("Ñ", "Nh");
        }
    }
}
