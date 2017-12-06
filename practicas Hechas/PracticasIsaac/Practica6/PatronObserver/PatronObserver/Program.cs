using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// ISAAC GUTIERREZ RODRIGUEZ
namespace PatronObserver
{
    /// <summary>
    /// Pruebas para comprobar el funcionamiento del codigo generado
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Madre madre = new Madre("Miriam");
            Padre padre = new Padre("Andres");

            Console.Out.WriteLine("Esposo:" + padre.Esposa);

            padre.Esposa = madre;

            Console.Out.WriteLine("Esposa: " + padre.Esposa.Nombre);
            Console.Out.WriteLine("Esposo: " + madre.Esposo.Nombre);

            Padre padre2 = new Padre("Pedro");

            madre.Esposo = padre2;

            Console.Out.WriteLine("Esposa: " + madre.Esposo.Nombre);

            Console.Out.WriteLine("Esposo 2: " + padre2.Esposa.Nombre);

            Console.Out.WriteLine("Esposo: " + padre.Esposa);

            madre.Esposo = null;

            Console.Out.WriteLine("Esposa: " + madre.Esposo);
            Console.Out.WriteLine("Esposo: " + padre.Esposa);
            Console.Out.WriteLine("Esposo2: " + padre2.Esposa);

            Console.ReadLine();
        }
    }
}
