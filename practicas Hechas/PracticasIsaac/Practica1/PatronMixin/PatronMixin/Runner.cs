using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixin
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
            PasiegoLebaniego p = new PasiegoLebaniego();

            // muestra el resultado de todos los metodos
            Console.Out.WriteLine(p.hacerCocido());
            Console.Out.WriteLine(p.hacerOrujo());
            Console.Out.WriteLine(p.hacerSobaos());
            Console.Out.WriteLine(p.hacerQuesada());

            Console.In.ReadLine();
        }
    }
}
