using CompositeSparrowEnlaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_06_Observer
{
    static class Program
    {
        static Directorio crearSistemaEjemplo()
        {
            Directorio dRaiz = new Directorio("Raiz");

            Directorio dVacio = new Directorio("Directorio Vacio");

            dRaiz.anadeElemento(dVacio);

            Directorio dUnico = new Directorio("Directorio Con Archivo Unico");
            Archivo f01 = new Archivo("foto001.jpg", 200);
            dUnico.anadeElemento(f01);

            dRaiz.anadeElemento(dUnico);

            Directorio d01 = new Directorio("Directorio Vacio En Archivo Comprimido");
            Archivo f02 = new Archivo("foto003.jpg", 200);
            EnlaceDirecto e01 = new EnlaceDirecto(f01);

            ArchivoComprimido ccSimple = new ArchivoComprimido("ccSimple.zip");
            ccSimple.anadeElemento(f02);
            ccSimple.anadeElemento(e01);
            ccSimple.anadeElemento(d01);

            Directorio dComprimido = new Directorio("Directorio Con Archivo Comprimido Simple");

            Archivo f03 = new Archivo("foto002.jpg", 200);
            EnlaceDirecto e02 = new EnlaceDirecto(f01);

            dComprimido.anadeElemento(f03);
            dComprimido.anadeElemento(e02);
            dComprimido.anadeElemento(ccSimple);

            dRaiz.anadeElemento(dComprimido);

            Archivo f04 = new Archivo("foto007.jpg", 200);
            ArchivoComprimido ccAnidada = new ArchivoComprimido("ccAnidada.zip");
            Archivo f05 = new Archivo("foto008.jpg", 200);

            ArchivoComprimido ccCompuesto = new ArchivoComprimido("ccComplejo.zip");
            ccCompuesto.anadeElemento(f05);

            Archivo f06 = new Archivo("foto005", 200);
            Archivo f07 = new Archivo("foto006", 200);

            Directorio dComprimidoCompuesto = new Directorio("Directorio con Archivo Comprimido Complejo");
            dComprimidoCompuesto.anadeElemento(f06);
            dComprimidoCompuesto.anadeElemento(f07);
            dComprimidoCompuesto.anadeElemento(ccCompuesto);

            Archivo f08 = new Archivo("foto004.jpg", 200);
            EnlaceDirecto e03 = new EnlaceDirecto(ccSimple);
            EnlaceDirecto e04 = new EnlaceDirecto(dVacio);

            Directorio dMultinivel = new Directorio("Directorio con Directorio Anidado");

            dMultinivel.anadeElemento(f08);
            dMultinivel.anadeElemento(e03);
            dMultinivel.anadeElemento(e04);
            dMultinivel.anadeElemento(dComprimidoCompuesto);

            dRaiz.anadeElemento(dMultinivel);

            return dRaiz;
        } // crearSistemaEjemplo

        /// <summary>
        ///     Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicializamos los aspectos básicos del sistema 
            // de ventanas
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creamos un nuevo gestor de multiformularios
            MultiWindowRunner runner = new MultiWindowRunner();

            // Creamos un sistema de Archivos ejemplo
            ElementoSistemaFicheros fs = crearSistemaEjemplo();

            // Creamos un nuevo visor de sistema de archivos Sparrow
            FileExplorerView fev = new FileExplorerView(runner);
            fev.SparrowFileSystem = fs;

            // Creamos un nuevo editor de nombres para los 
            // elementos del sistema de archivos Sparrow anterior
            FileNameEditor fne = new FileNameEditor(runner);
            fne.SparrowFileSystem = fs;

            // Registramos ambos formularios en el gestor de formularios
            runner.registerForm(fne);
            runner.registerForm(fev);

            // Ejecutamos los formularios
            runner.run();
        } // main
    } // Program
}
