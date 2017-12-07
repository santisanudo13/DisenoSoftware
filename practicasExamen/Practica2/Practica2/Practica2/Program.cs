using System;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo("pepe.doc", 12);
            Directorio directorio = new Directorio("documentos pepe", 0);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("documentos pepe comprimido", 0);

            directorio.addElement(archivo);

            archivoComprimido.addElement(directorio);


            Console.Out.WriteLine("tamano archivo  " + archivo.totalSize());

            Console.Out.WriteLine("tamano directorio  " + directorio.totalSize());

            Console.Out.WriteLine("tamano archivo comprimido  " + archivoComprimido.totalSize());

            Console.Out.WriteLine("numarchivos archivo  " + archivo.totalFiles());

            Console.Out.WriteLine("numarchivos directorio  " + directorio.totalFiles());

            Console.Out.WriteLine("numarchivos archivo comprimido  " + archivoComprimido.totalFiles());

            EnlaceDirecto enlace = new EnlaceDirecto("enlaceDirecto", 0, archivoComprimido);
            directorio.addElement(enlace);

            Console.Out.WriteLine();

            Console.Out.WriteLine("Enlace Anadido");
            Console.Out.WriteLine(enlace.Nombre);

            Console.Out.WriteLine("tamano directorio " + directorio.totalSize());
            Console.Out.WriteLine("numarchivos directorio " + directorio.totalFiles());

            Console.In.ReadLine();

        }
    }
}
