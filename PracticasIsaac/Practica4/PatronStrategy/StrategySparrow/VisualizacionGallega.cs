using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace StrategySparrow
{
    /// <summary>
    /// Visualizacion: Estrategia Gallega
    /// </summary>
    public class VisualizacionGallega : Visualizacion
    {
        private const String stringReemplazo = "nh";

        public override String visualizacion(String str)
        {
            return str.Replace("ñ",stringReemplazo);
        }
    }
}
