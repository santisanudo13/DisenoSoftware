using System;
using AbstractFactorySparrow.Estrategias;
using AbstractFactorySparrow.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrow.Factorias
{
    /// <summary>
    /// Factoria concreta para la opcion de visualizacion estandar
    ///     Esta visualizacion utiliza una impresora extendida junto con la estrategia castellano
    /// </summary>
    public class FactoriaConcretaVisualizacionEstandar: AbstractFactoryVisualizacion
    { 
        //instancia de la factoria
        private static FactoriaConcretaVisualizacionEstandar instancia;

        /// <summary>
        /// Metodo protegido para la creacion de la factoria
        /// </summary>
        protected FactoriaConcretaVisualizacionEstandar() { }

        /// <summary>
        /// Metodo estatico que permite obtener la instancia de la factoria
        /// </summary>
        /// <returns> instancia de la factoria </returns>
        public static FactoriaConcretaVisualizacionEstandar getInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoriaConcretaVisualizacionEstandar();
            }
            return instancia;
        }

        /// <summary>
        /// Crea la estrategia de visualizacion a utilizar en esta factoria
        /// </summary>
        /// <returns> estrategia a utilizar </returns>
        public override Visualizacion crearVisualizacion()
        {
            return new VisualizacionCastellano();
        }

        /// <summary>
        /// Crea la impresora a utilizar en esta factoria
        /// </summary>
        /// <param name="visualizacion"> estrategia de visualizacion a utilizar </param>
        /// <returns> impresora creada </returns>
        ///
        /// Pre: visualizacion instaceof VisualizacionCastellano
        ///
        public override Impresora crearImpresora(Visualizacion visualizacion)
        {
            return new ImpresoraExtendida(visualizacion);
        }
    }
}
