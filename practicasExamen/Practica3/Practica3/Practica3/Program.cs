using System;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            Directorio raiz = new Directorio("Raiz");
            Directorio directorioVacio = new Directorio("Directorio Vacio");
            Directorio directorioArchivo = new Directorio("Directorio Con Archivo Unico");
            Archivo foto001 = new Archivo("foto001.jpg", 120);

            raiz.addElement(directorioVacio);
            raiz.addElement(directorioArchivo);
            directorioArchivo.addElement(foto001);

            Directorio directorioComprSimple = new Directorio("Directorio Con Archivo Comprimido Simple");
            Archivo foto002 = new Archivo("foto002.jpg", 120);
            EnlaceDirecto enlaceFoto001 = new EnlaceDirecto(foto001, foto001.Nombre);
            ArchivoComprimido ccSimple = new ArchivoComprimido("ccSimple.zip");

            directorioComprSimple.addElement(foto002);
            directorioComprSimple.addElement(enlaceFoto001);

            Directorio dirVacioEnCompr = new Directorio("Directorio Vacio En Archivo Comprimido");
            Archivo foto003 = new Archivo("foto003.jpg", 120);
            ccSimple.addElement(dirVacioEnCompr);
            ccSimple.addElement(foto003);
            ccSimple.addElement(enlaceFoto001);

            directorioComprSimple.addElement(ccSimple);

            raiz.addElement(directorioComprSimple);

            Directorio directorioAnidado = new Directorio("Directorio Con Directorio Anidado");
            Archivo foto004 = new Archivo("foto004.jpg", 120);
            EnlaceDirecto enlaceCCSimple = new EnlaceDirecto(ccSimple, ccSimple.Nombre);
            EnlaceDirecto enlaceDirVacio = new EnlaceDirecto(directorioVacio, directorioVacio.Nombre);

            directorioAnidado.addElement(foto004);
            directorioAnidado.addElement(enlaceCCSimple);
            directorioAnidado.addElement(enlaceDirVacio);

            Directorio directorioComprCompl = new Directorio("Directorio Con Archivo Comprimido Complejo");
            Archivo foto005 = new Archivo("foto005", 120);
            Archivo foto006 = new Archivo("foto006", 120);

            directorioComprCompl.addElement(foto005);
            directorioComprCompl.addElement(foto006);

            ArchivoComprimido ccComplejo = new ArchivoComprimido("ccComplejo.zip");
            Archivo foto007 = new Archivo("foto007.jpg", 120);
            Archivo foto008 = new Archivo("foto008.jpg", 120);

            ArchivoComprimido ccAnidada = new ArchivoComprimido("ccAnidada.zip");
            ccAnidada.addElement(foto007);

            ccComplejo.addElement(ccAnidada);
            ccComplejo.addElement(foto008);

            directorioComprCompl.addElement(ccComplejo);
            directorioAnidado.addElement(directorioComprCompl);
            raiz.addElement(directorioAnidado);


            Console.Out.WriteLine(" -----   VERSION COMPACTA ----- \n");

            Visitor impresoraCompacta = new VisitorCompacto();
            Console.Out.Write(impresoraCompacta.visitDirectorio(raiz));


            Console.Out.WriteLine("\n -----   FIN VERSION COMPACTA ----- \n\n\n\n");

            Console.Out.WriteLine(" -----   VERSION EXTENDIDA ----- \n");

            Visitor impresoraExtendida = new VisitorExtendido();
            Console.Out.Write(impresoraExtendida.visitDirectorio(raiz));


            Console.Out.WriteLine("\n -----   FIN VERSION EXTENDIDA ----- ");

            Console.ReadLine();
        }
    }
}
