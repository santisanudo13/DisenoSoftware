using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategySparrowLambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace StrategySparrowLambda.Tests
{
    /// <summary>
    /// Pruebas para la estrategia de visualizacion internacional catalan
    /// </summary>
    [TestClass()]
    public class VisualizacionInternacionalCatalanTest
    {
        ImpresoraExtendida impExt;
        ImpresoraCompacta impComp;

        String[] castellano = { "ñ", "á", "é", "í", "ó", "ú" };
        String[] internacionalCatalan = { "ny", "a", "e", "i", "o", "u" };

        /// TEST PARA LA IMPRESORA EXTENDIDA

        [TestMethod()]
        public void imprimirInternacionalCatalanExtendidaLambdaNTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            { 
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "f Foto Espanya\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanExtendidaLambdaAConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Directorio directorio = new Directorio("Más fotos");
            String actual = impExt.imprimirDirectorio(directorio, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "d Mas fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanExtendidaLambdaEConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "f Foto Jose\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanExtendidaLambdaIConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "f Calibri fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanExtendidaLambdaOConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "f Grabacion Television\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanExtendidaLambdaUConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impExt.imprimirArchivoComprimido(archivoComprimido, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "c Aun Fotos\n";
            Assert.AreEqual(expected, actual);
        }

        /// TEST PARA LA IMPRESORA COMPACTA

        [TestMethod()]
        public void imprimirInternacionalCatalanCompactaLambdaNTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "f Foto Espanya\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanCompactaLambdaAConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Directorio directorio = new Directorio("Más fotos");
            String actual = impComp.imprimirDirectorio(directorio, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "d Mas fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanCompactaLambdaEConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "f Foto Jose\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanCompactaLambdaIConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "f Calibri fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanCompactaLambdaOConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "f Grabacion Television\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanCompactaLambdaUConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impComp.imprimirArchivoComprimido(archivoComprimido, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });
            String expected = "c Aun Fotos\n";
            Assert.AreEqual(expected, actual);
        }
    }
}