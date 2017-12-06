using Ninject.Modules;
using AbstractFactorySparrowInjection.Estrategias;
using AbstractFactorySparrowInjection.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowInjection.Configurations
{
    /// <summary>
    /// Inyeccion de dependencias para la opcion extendida catalana
    /// </summary>
    public class ExtendidaCatalana : NinjectModule
    {
        public override void Load()
        {
            Bind<Visualizacion>().To<VisualizacionInternacionalCatalana>();
            Bind<Impresora>().To<ImpresoraExtendida>();
        }
    }
}
