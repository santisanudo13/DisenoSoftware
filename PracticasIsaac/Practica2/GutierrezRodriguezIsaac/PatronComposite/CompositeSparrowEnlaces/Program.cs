using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Isaac Gutierrez Rodriguez
namespace CompositeSparrowEnlaces
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

            directorio.anadeElemento(archivo);

            archivoComprimido.anadeElemento(directorio);


            Console.Out.WriteLine("tamano archivo  " + archivo.calcularTamanyo());

            Console.Out.WriteLine("tamano directorio  " + directorio.calcularTamanyo());

            Console.Out.WriteLine("tamano archivo comprimido  " + archivoComprimido.calcularTamanyo());

            Console.Out.WriteLine("numarchivos archivo  " + archivo.numArchivos());

            Console.Out.WriteLine("numarchivos directorio  " + directorio.numArchivos());

            Console.Out.WriteLine("numarchivos archivo comprimido  " + archivoComprimido.numArchivos());

            EnlaceDirecto enlace = new EnlaceDirecto(archivoComprimido);
            directorio.anadeElemento(enlace);

            Console.Out.WriteLine();

            Console.Out.WriteLine("Enlace Anadido");

            Console.Out.WriteLine("tamano directorio " + directorio.calcularTamanyo());
            Console.Out.WriteLine("numarchivos directorio " + directorio.numArchivos());

            Console.In.ReadLine();
        }
    }
}
