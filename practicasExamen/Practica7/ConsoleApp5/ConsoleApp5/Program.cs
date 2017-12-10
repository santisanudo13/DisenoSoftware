using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Directorio dRaiz = new Directorio("Raiz");

            Directorio dVacio = new Directorio("Directorio Vacio");

            dRaiz.Archivos.Add(dVacio);

            Directorio dUnico = new Directorio("Directorio Con Archivo Unico");
            Archivo f01 = new Archivo(200, "foto001.jpg");
            dUnico.Archivos.Add(f01);

            dRaiz.Archivos.Add(dUnico);

            Directorio d01 = new Directorio("Directorio Vacio En Archivo Comprimido");
            Archivo f02 = new Archivo(200, "foto003.jpg");
            Enlace e01 = new Enlace(f01.Nombre, f01);

            Comprimido ccSimple = new Comprimido("ccSimple.zip");
            ccSimple.Archivos.Add(d01);
            ccSimple.Archivos.Add(f02);
            ccSimple.Archivos.Add(e01);

            Directorio dComprimido = new Directorio("Directorio Con Archivo Comprimido Simple");

            Archivo f03 = new Archivo(200, "foto002.jpg");
            Enlace e02 = new Enlace(f01.Nombre, f01);

            dComprimido.Archivos.Add(f03);
            dComprimido.Archivos.Add(e02);
            dComprimido.Archivos.Add(ccSimple);

            dRaiz.Archivos.Add(dComprimido);

            Archivo f04 = new Archivo(200, "foto007.jpg");
            Comprimido ccAnidada = new Comprimido("ccAnidada.zip");
            ccAnidada.Archivos.Add(f04);
            Archivo f05 = new Archivo(200, "foto008.jpg");

            Comprimido ccCompuesto = new Comprimido("ccComplejo.zip");
            ccCompuesto.Archivos.Add(ccAnidada);
            ccCompuesto.Archivos.Add(f05);

            Archivo f06 = new Archivo(200, "foto005");
            Archivo f07 = new Archivo(200, "foto006");

            Directorio dComprimidoCompuesto = new Directorio("Directorio con Archivo Comprimido Complejo");
            dComprimidoCompuesto.Archivos.Add(f06);
            dComprimidoCompuesto.Archivos.Add(f07);
            dComprimidoCompuesto.Archivos.Add(ccCompuesto);

            Archivo f08 = new Archivo(200, "foto004.jpg");
            Enlace e03 = new Enlace(ccSimple.Nombre, ccSimple);
            Enlace e04 = new Enlace(dVacio.Nombre, dVacio);

            Directorio dMultinivel = new Directorio("Directorio con Directorio Anidado");

            dMultinivel.Archivos.Add(f08);
            dMultinivel.Archivos.Add(e03);
            dMultinivel.Archivos.Add(e04);
            dMultinivel.Archivos.Add(dComprimidoCompuesto);

            dRaiz.Archivos.Add(dMultinivel);


            IEnumerator<Fichero> iterator = dRaiz.GetEnumerator();

            while(iterator.MoveNext())
            {
                Console.Out.WriteLine(iterator.Current.Nombre);

            }
           

            Console.ReadKey();
        }
    }
}
