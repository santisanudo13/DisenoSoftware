using System;
using AbstractFactorySparrowPrototype.Estrategias;
using AbstractFactorySparrowPrototype.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowPrototype.Factorias
{
    /// <summary>
    /// Factoria abstracta que soporta la creación de visitantes y estrategias concretas
    /// </summary>
    public abstract class AbstractFactoryVisualizacion
    {
        /// <summary>
        /// Crea la visualizacion
        /// </summary>
        /// <returns> visualizacion creada </returns>
        public abstract Visualizacion crearVisualizacion();

        /// <summary>
        /// Crea la impresora
        /// </summary>
        /// <param name="visualizacion"> estrategia a utilizar para la visualizacion del sistema de ficheros </param>
        /// <returns> impresora creada </returns>
        public abstract Impresora crearImpresora(Visualizacion visualizacion);
    }
}
