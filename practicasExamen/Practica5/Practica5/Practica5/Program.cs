using System;

namespace Practica5
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Creación Sistema de Ficheros
            Directorio raiz = new Directorio("Raiz");
            Directorio directorioVacio = new Directorio("Directorio Vacío");
            Directorio directorioArchivo = new Directorio("Directorio Con Archivo Único");
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

            Directorio dirVacioEnCompr = new Directorio("Directorio Vacío En Archivo Comprimido");
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
            Archivo foto007 = new Archivo("foto007España.jpg", 120);
            Archivo foto008 = new Archivo("foto008.jpg", 120);

            ArchivoComprimido ccAnidada = new ArchivoComprimido("ccAnidada.zip");
            ccAnidada.addElement(foto007);

            ccComplejo.addElement(ccAnidada);
            ccComplejo.addElement(foto008);

            directorioComprCompl.addElement(ccComplejo);
            directorioAnidado.addElement(directorioComprCompl);
            raiz.addElement(directorioAnidado);

            #endregion

            #region Prueba Extendida Abierta

            Console.Out.WriteLine("\n\n Extendida Abierta \n\n");

            FactoryVisitorExtendidoAbierto.setVisualizacion(new TipografiaGallega());

            Factory factoriaAbierta = FactoryVisitorExtendidoAbierto.getInstance();
            Tipografia tipografiaAbierta = factoriaAbierta.crearTipografia();
            Visitor visitorExtendidaAbierta = factoriaAbierta.crearVisitor(tipografiaAbierta);
            Console.Out.Write(visitorExtendidaAbierta.visitDirectorio(raiz));

            #endregion

            Console.ReadLine();
        }
    }
}
