using Ninject.Modules;
using AbstractFactorySparrowInjection.Estrategias;
using AbstractFactorySparrowInjection.Impresoras;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrowInjection.Configurations
{
    /// <summary>
    /// Inyeccion de dependencias para la opcion estandar
    /// </summary>
    public class Estandar : NinjectModule
    {
        public override void Load()
        {
            Bind<Visualizacion>().To<VisualizacionCastellano>();
            Bind<Impresora>().To<ImpresoraExtendida>();
        }
    }
}
