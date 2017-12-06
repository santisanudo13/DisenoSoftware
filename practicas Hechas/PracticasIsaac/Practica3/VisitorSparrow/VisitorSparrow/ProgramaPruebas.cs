using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace VisitorSparrow
{
    /// <summary>
    /// Programa de pruebas del patron visitor. 
    /// En este programa de pruebas se imprime el directorio definido en el guion de la practica:
    ///
    ///  - de forma compacta
    ///  - de forma extendida
    ///  
    /// </summary>
    public class ProgramaPruebas
    {
        public static void Main(string[] args)
        {

            Directorio raiz = new Directorio("Raiz");
            Directorio directorioVacio = new Directorio("Directorio Vacio");
            Directorio directorioArchivo = new Directorio("Directorio Con Archivo Unico");
            Archivo foto001 = new Archivo("foto001.jpg", 120);

            raiz.anadeElemento(directorioVacio);
            raiz.anadeElemento(directorioArchivo);
            directorioArchivo.anadeElemento(foto001);

            Directorio directorioComprSimple = new Directorio("Directorio Con Archivo Comprimido Simple");
            Archivo foto002 = new Archivo("foto002.jpg", 120);
            EnlaceDirecto enlaceFoto001 = new EnlaceDirecto(foto001);
            ArchivoComprimido ccSimple = new ArchivoComprimido("ccSimple.zip");

            directorioComprSimple.anadeElemento(foto002);
            directorioComprSimple.anadeElemento(enlaceFoto001);

            Directorio dirVacioEnCompr = new Directorio("Directorio Vacio En Archivo Comprimido");
            Archivo foto003 = new Archivo("foto003.jpg", 120);
            ccSimple.anadeElemento(dirVacioEnCompr);
            ccSimple.anadeElemento(foto003);
            ccSimple.anadeElemento(enlaceFoto001);

            directorioComprSimple.anadeElemento(ccSimple);

            raiz.anadeElemento(directorioComprSimple);

            Directorio directorioAnidado = new Directorio("Directorio Con Directorio Anidado");
            Archivo foto004 = new Archivo("foto004.jpg", 120);
            EnlaceDirecto enlaceCCSimple = new EnlaceDirecto(ccSimple);
            EnlaceDirecto enlaceDirVacio = new EnlaceDirecto(directorioVacio);

            directorioAnidado.anadeElemento(foto004);
            directorioAnidado.anadeElemento(enlaceCCSimple);
            directorioAnidado.anadeElemento(enlaceDirVacio);

            Directorio directorioComprCompl = new Directorio("Directorio Con Archivo Comprimido Complejo");
            Archivo foto005 = new Archivo("foto005", 120);
            Archivo foto006 = new Archivo("foto006", 120);

            directorioComprCompl.anadeElemento(foto005);
            directorioComprCompl.anadeElemento(foto006);

            ArchivoComprimido ccComplejo = new ArchivoComprimido("ccComplejo.zip");
            Archivo foto007 = new Archivo("foto007.jpg", 120);
            Archivo foto008 = new Archivo("foto008.jpg", 120);

            ArchivoComprimido ccAnidada = new ArchivoComprimido("ccAnidada.zip");
            ccAnidada.anadeElemento(foto007);

            ccComplejo.anadeElemento(ccAnidada);
            ccComplejo.anadeElemento(foto008);

            directorioComprCompl.anadeElemento(ccComplejo);
            directorioAnidado.anadeElemento(directorioComprCompl);
            raiz.anadeElemento(directorioAnidado);


            Console.Out.WriteLine(" -----   VERSION COMPACTA ----- \n");

            Impresora impresoraCompacta = new ImpresoraCompacta();
            Console.Out.Write(impresoraCompacta.imprimirDirectorio(raiz));


            Console.Out.WriteLine("\n -----   FIN VERSION COMPACTA ----- \n\n\n\n");

            Console.Out.WriteLine(" -----   VERSION EXTENDIDA ----- \n");

            Impresora impresoraExtendida = new ImpresoraExtendida();
            Console.Out.Write(impresoraExtendida.imprimirDirectorio(raiz));


            Console.Out.WriteLine("\n -----   FIN VERSION EXTENDIDA ----- ");

            Console.ReadLine();
        }
    }
}
