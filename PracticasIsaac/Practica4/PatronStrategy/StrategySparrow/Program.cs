using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace StrategySparrow
{
    /// <summary>
    /// Programa de pruebas para el patron strategy
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Directorio d = new Directorio("Español áéíóú");

            ImpresoraExtendida impExt = new ImpresoraExtendida(new VisualizacionCatalana());
            ImpresoraExtendida impExt2 = new ImpresoraExtendida(new VisualizacionGallega());
            ImpresoraExtendida impExt3 = new ImpresoraExtendida(new VisualizacionCastellano());
            ImpresoraExtendida impExt4 = new ImpresoraExtendida(new VisualizacionInternacionalCatalana());
            ImpresoraExtendida impExt5 = new ImpresoraExtendida(new VisualizacionInternacionalGallega());

            ImpresoraCompacta impComp = new ImpresoraCompacta(new VisualizacionCatalana());
            ImpresoraCompacta impComp2 = new ImpresoraCompacta(new VisualizacionGallega());
            ImpresoraCompacta impComp3 = new ImpresoraCompacta(new VisualizacionCastellano());
            ImpresoraCompacta impComp4 = new ImpresoraCompacta(new VisualizacionInternacionalCatalana());
            ImpresoraCompacta impComp5 = new ImpresoraCompacta(new VisualizacionInternacionalGallega());

            Console.Out.WriteLine("-------- IMPRESORA EXTENDIDA --------\n");

            Console.Out.WriteLine("Catalan: " + impExt.imprimirDirectorio(d));
            Console.Out.WriteLine("Gallego: " + impExt2.imprimirDirectorio(d));
            Console.Out.WriteLine("Castellano: " + impExt3.imprimirDirectorio(d));
            Console.Out.WriteLine("Internacional Catalan: " + impExt4.imprimirDirectorio(d));
            Console.Out.WriteLine("Internacional Gallego: " + impExt5.imprimirDirectorio(d));

            Console.Out.WriteLine("-------- IMPRESORA COMPACTA --------\n");

            Console.Out.WriteLine("Catalan: " + impComp.imprimirDirectorio(d));
            Console.Out.WriteLine("Gallego: " + impComp2.imprimirDirectorio(d));
            Console.Out.WriteLine("Castellano: " + impComp3.imprimirDirectorio(d));
            Console.Out.WriteLine("Internacional Catalan: " + impComp4.imprimirDirectorio(d));
            Console.Out.WriteLine("Internacional Gallego: " + impComp5.imprimirDirectorio(d));

            Console.ReadLine();

        }
    }
}
