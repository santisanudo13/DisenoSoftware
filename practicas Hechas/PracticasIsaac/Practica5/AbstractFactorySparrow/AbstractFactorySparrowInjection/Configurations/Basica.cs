using Ninject.Modules;
using AbstractFactorySparrowInjection.Estrategias;
using AbstractFactorySparrowInjection.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowInjection.Configurations
{
    /// <summary>
    /// Inyeccion de dependencias para la opcion basica
    /// </summary>
    public class Basica : NinjectModule
    {
        public override void Load()
        {
            Bind<Visualizacion>().To<VisualizacionInternacionalGallega>();
            Bind<Impresora>().To<ImpresoraCompacta>();
        }
    }
}
