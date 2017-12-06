using System;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowPrototype.Estrategias
{
    /// <summary>
    /// Visualizacion: Estrategia Internacional Catalana
    /// </summary>
    public class VisualizacionInternacionalCatalana : Visualizacion
    {
        private const String stringReemplazo = "ny";

        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para la estrategia internacional catalana
        /// </summary>
        /// <param name="str"> string conteniendo el sistema de ficheros a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia internacional catalana </returns>
        public override String visualizacion(String str)
        {
            str = str.Replace("ñ", stringReemplazo);
            str = str.Replace("á", "a");
            str = str.Replace("ú", "u");
            str = str.Replace("í", "i");
            str = str.Replace("ó", "o");
            str = str.Replace("é", "e");
            str = str.Replace("Ñ", "Ny");
            str = str.Replace("Á", "A");
            str = str.Replace("Ú", "U");
            str = str.Replace("Í", "I");
            str = str.Replace("Ó", "O");
            str = str.Replace("É", "E");

            return str;
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
