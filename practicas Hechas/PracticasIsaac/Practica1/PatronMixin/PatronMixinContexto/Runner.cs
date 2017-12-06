using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixinContexto
{
    /**
     * <summary>
     * Runner
     * Clase que muestra por pantalla el resultado de los distintos metodos implimentados
     * </summary>
     */
    class Runner
    {
        static void Main(string[] args)
        {
            // crea un PasiegoLebaniego con contexto inicial Liebana
            PasiegoLebaniego p = new PasiegoLebaniego(TipoContexto.LIEBANA);

            // muestra el resultado de todos los metodos (excepto hacerCocidos() del tipo pasiego)
            Console.Out.WriteLine(p.hacerCocido());
            Console.Out.WriteLine(p.hacerOrujo());
            Console.Out.WriteLine(p.hacerSobaos());
            Console.Out.WriteLine(p.hacerQuesada());

            // cambio de contexto para mostrar el resultado del metodo hacerCocido() con el contexto PAS
            p.Contexto = TipoContexto.PAS;

            // muestra el resultado del metodo hacerCocido() para el contexto PAS
            Console.Out.WriteLine(p.hacerCocido());

            Console.In.ReadLine();
        }
    }
}
