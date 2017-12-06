using System;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowPrototype.Estrategias
{
    /// <summary>
    /// Visualizacion: Estrategia Catalana
    /// </summary>
    public class VisualizacionCatalana : Visualizacion
    {

        private const String stringReemplazo = "ny";

        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para la estrategia catalana
        /// </summary>
        /// <param name="str"> string conteniendo el sistema de ficheros a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia catalana </returns>
        public override String visualizacion(String str)
        {
            str = str.Replace("ñ", stringReemplazo);
            return str.Replace("Ñ", "ny");
        }

        /// <summary>
        /// Metodo que oermite obtener una copia de la estretegia
        /// </summary>
        /// <returns> clon de la estrategia de visualizacion</returns>
        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
