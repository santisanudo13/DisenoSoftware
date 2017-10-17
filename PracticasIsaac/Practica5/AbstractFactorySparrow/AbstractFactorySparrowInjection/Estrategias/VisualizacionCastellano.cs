using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowInjection.Estrategias
{
    /// <summary>
    /// Visualizacion: Estrategia Castellano
    /// </summary>
    public class VisualizacionCastellano : Visualizacion
    {
        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para la estrategia castellano
        /// </summary>
        /// <param name="str"> string conteniendo el sistema de ficheros a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia castellano </returns>
        public override String visualizacion(String str)
        {
            return str;
        }
    }
}
