using System;
using AbstractFactorySparrow.Estrategias;
using AbstractFactorySparrow.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrow.Factorias
{
    /// <summary>
    /// Factoria concreta para la opcion de visualizacion basica
    ///     Esta visualizacion utiliza una impresora compacta junto con la estrategia internacional gallega
    /// </summary>
    public class FactoriaConcretaVisualizacionBasica: AbstractFactoryVisualizacion
    {
        //instancia de la factoria
        private static FactoriaConcretaVisualizacionBasica instancia;

        /// <summary>
        /// Metodo protegido para la creacion de la factoria
        /// </summary>
        protected FactoriaConcretaVisualizacionBasica() { }

        /// <summary>
        /// Metodo estatico que permite obtener la instancia de la factoria
        /// </summary>
        /// <returns> instancia de la factoria </returns>
        public static FactoriaConcretaVisualizacionBasica getInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoriaConcretaVisualizacionBasica();
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
            return new ImpresoraCompacta(visualizacion);
        }
    }
}
