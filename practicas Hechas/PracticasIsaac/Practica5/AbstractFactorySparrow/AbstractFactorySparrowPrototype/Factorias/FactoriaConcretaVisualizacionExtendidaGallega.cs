using System;
using AbstractFactorySparrowPrototype.Estrategias;
using AbstractFactorySparrowPrototype.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowPrototype.Factorias
{
    /// <summary>
    /// Factoria concreta para la opcion de visualizacion extendida gallega
    ///     Esta visualizacion utiliza una impresora extendida junto con la estrategia internacional gallega
    /// </summary>
    public class FactoriaConcretaVisualizacionExtendidaGallega: AbstractFactoryVisualizacion
    {
        //instancia de la factoria
        private static FactoriaConcretaVisualizacionExtendidaGallega instancia;

        /// <summary>
        /// Metodo protegido para la creacion de la factoria
        /// </summary>
        protected FactoriaConcretaVisualizacionExtendidaGallega() { }

        /// <summary>
        /// Metodo estatico que permite obtener la instancia de la factoria
        /// </summary>
        /// <returns> instancia de la factoria </returns>
        public static FactoriaConcretaVisualizacionExtendidaGallega getInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoriaConcretaVisualizacionExtendidaGallega();
            }
            return instancia;
        }

        /// <summary>
        /// Crea la estrategia de visualizacion a utilizar en esta factoria
        /// </summary>
        /// <returns> estrategia a utilizar </returns>
        public override Visualizacion crearVisualizacion()
        {
            return new VisualizacionInternacionalGallega();
        }

        /// <summary>
        /// Crea la impresora a utilizar en esta factoria
        /// </summary>
        /// <param name="visualizacion"> estrategia de visualizacion a utilizar </param>
        /// <returns> impresora creada </returns>
        ///
        /// Pre: visualizacion instaceof VisualizacionInternacionalGallega
        ///
        public override Impresora crearImpresora(Visualizacion visualizacion)
        {
            return new ImpresoraExtendida(visualizacion);
        }
    }
}
