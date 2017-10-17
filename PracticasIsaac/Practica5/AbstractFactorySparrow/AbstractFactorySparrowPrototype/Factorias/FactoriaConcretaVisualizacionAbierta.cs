using System;
using AbstractFactorySparrowPrototype.Estrategias;
using AbstractFactorySparrowPrototype.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowPrototype.Factorias
{
    /// <summary>
    /// Factoria concreta para la opcion de visualizacion personalizada
	///     Esta visualizacion utiliza una impresora extendida junto con la estrategia personalizada
	/// 	establecida por el usuario
    /// </summary>
    public class FactoriaConcretaVisualizacionAbierta: AbstractFactoryVisualizacion
    {
        //instancia de la factoria
        private static FactoriaConcretaVisualizacionAbierta instancia;
        private static Visualizacion estrategia;

        /// <summary>
        /// Metodo protegido para la creacion de la factoria
        /// </summary>
        protected FactoriaConcretaVisualizacionAbierta() { }

        /// <summary>
        /// Metodo estatico que permite obtener la instancia de la factoria
        /// </summary>
        /// <returns> instancia de la factoria </returns>
        public static FactoriaConcretaVisualizacionAbierta getInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoriaConcretaVisualizacionAbierta();
            }
            return instancia;
        }

		/// <summary>
		/// Metodo estatico que permite establecer la estrategia personalizada a utilizar
		/// </summary>
		/// <param name="visualizacion"> estrategia personalizada a utilizar </param>
        public static void setVisualizacion(Visualizacion visualizacion)
        {
            estrategia = visualizacion;
        }

        /// <summary>
        /// Crea la estrategia de visualizacion a utilizar en esta factoria
        /// </summary>
        /// <returns> estrategia a utilizar </returns>
        public override Visualizacion crearVisualizacion()
        {
            return (Visualizacion)estrategia.Clone();
        }

        /// <summary>
        /// Crea la impresora a utilizar en esta factoria
        /// </summary>
        /// <param name="visualizacion"> estrategia de visualizacion a utilizar </param>
        /// <returns> impresora creada </returns>
        ///
        public override Impresora crearImpresora(Visualizacion visualizacion)
        {
            return new ImpresoraExtendida(visualizacion);
        }
    }
}
