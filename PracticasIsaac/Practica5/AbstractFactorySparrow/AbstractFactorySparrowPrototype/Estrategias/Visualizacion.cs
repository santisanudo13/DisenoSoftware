using System;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowPrototype.Estrategias
{
    /// <summary>
    /// Visualizacion
    /// </summary>
    public abstract class Visualizacion: ICloneable
    {

        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para la estrategia
        /// </summary>
        /// <param name="str"> string conteniendo el sistema de ficheros a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia </returns>
        public abstract String visualizacion(String str);

        /// <summary>
        /// Metodo que oermite obtener una copia de la estretegia
        /// </summary>
        /// <returns> clon de la estrategia de visualizacion</returns>
        public abstract object Clone();
    }
}
