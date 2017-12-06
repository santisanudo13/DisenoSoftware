using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace StrategySparrow
{
    /// <summary>
    /// Visualizacion
    /// </summary>
    public abstract class Visualizacion
    {
        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para la estrategia
        /// </summary>
        /// <param name="str"> string conteniendo el sistema de ficheros a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia </returns>
        public abstract String visualizacion(String str);
    }
}
