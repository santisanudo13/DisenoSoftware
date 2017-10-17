using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Isaac Gutierrez Rodriguez
namespace CompositeSparrow
{
    /// <summary>
    /// Programa de pruebas
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo("pepe.doc", 12);
            Directorio directorio = new Directorio("documentos pepe");
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("documentos pepe comprimido");

            try
            {
                directorio.anadeElemento(archivo);

                archivoComprimido.anadeElemento(directorio);

            }
            catch (InvalidCastException e)
            {
                Console.Out.WriteLine(e.ToString());
            }

            Console.Out.WriteLine("tamano archivo  " + archivo.calcularTamanyo());

            Console.Out.WriteLine("tamano directorio  " + directorio.calcularTamanyo());

            Console.Out.WriteLine("tamano archivo comprimido  " + archivoComprimido.calcularTamanyo());

            Console.Out.WriteLine("numarchivos archivo  " + archivo.numArchivos());

            Console.Out.WriteLine("numarchivos directorio  " + directorio.numArchivos());

            Console.Out.WriteLine("numarchivos archivo comprimido  " + archivoComprimido.numArchivos());

            Console.In.ReadLine();
        }
    }
}
