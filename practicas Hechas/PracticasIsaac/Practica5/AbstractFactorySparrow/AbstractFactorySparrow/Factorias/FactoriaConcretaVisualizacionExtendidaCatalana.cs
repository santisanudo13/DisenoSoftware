using System;
using AbstractFactorySparrow.Estrategias;
using AbstractFactorySparrow.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrow.Factorias
{
    /// <summary>
    /// Factoria concreta para la opcion de visualizacion estandar
    ///     Esta visualizacion utiliza una impresora extendida junto con la estrategia internacional catalana
    /// </summary>
    public class FactoriaConcretaVisualizacionExtendidaCatalana: AbstractFactoryVisualizacion
    {
        //instancia de la factoria
        private static FactoriaConcretaVisualizacionExtendidaCatalana instancia;

        /// <summary>
        /// Metodo protegido para la creacion de la factoria
        /// </summary>
        protected FactoriaConcretaVisualizacionExtendidaCatalana() { }

        /// <summary>
        /// Metodo estatico que permite obtener la instancia de la factoria
        /// </summary>
        /// <returns> instancia de la factoria </returns>
        public static FactoriaConcretaVisualizacionExtendidaCatalana getInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoriaConcretaVisualizacionExtendidaCatalana();
            }
            return instancia;
        }

        /// <summary>
        /// Crea la estrategia de visualizacion a utilizar en esta factoria
        /// </summary>
        /// <returns> estrategia a utilizar </returns>
        public override Visualizacion crearVisualizacion()
        {
            return new VisualizacionInternacionalCatalana();
        }

        /// <summary>
        /// Crea la impresora a utilizar en esta factoria
        /// </summary>
        /// <param name="visualizacion"> estrategia de visualizacion a utilizar </param>
        /// <returns> impresora creada </returns>
        ///
        /// Pre: visualizacion instaceof VisualizacionInternacionalCatalana
        ///
        public override Impresora crearImpresora(Visualizacion visualizacion)
        {
            return new ImpresoraExtendida(visualizacion);
        }
    }
}
