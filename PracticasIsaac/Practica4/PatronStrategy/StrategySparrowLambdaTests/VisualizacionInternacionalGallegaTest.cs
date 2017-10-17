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
    /// Pruebas para la estrategia de visualizacion internacional gallego
    /// </summary>
    [TestClass()]
    public class VisualizacionInternacionalGallegaTest
    {
        ImpresoraExtendida impExt;
        ImpresoraCompacta impComp;

        String[] castellano = { "ñ", "á", "é", "í", "ó", "ú" };
        String[] internacionalGallego = { "nh", "a", "e", "i", "o", "u" };

        /// TEST PARA LA IMPRESORA EXTENDIDA

        [TestMethod()]
        public void imprimirInternacionalGallegoExtendidaLambdaNTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            { 
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "f Foto Espanha\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegoExtendidaLambdaAConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Directorio directorio = new Directorio("Más fotos");
            String actual = impExt.imprimirDirectorio(directorio, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "d Mas fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegoExtendidaLambdaEConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "f Foto Jose\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegoExtendidaLambdaIConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "f Calibri fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegoExtendidaLambdaOConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "f Grabacion Television\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegoExtendidaLambdaUConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impExt.imprimirArchivoComprimido(archivoComprimido, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "c Aun Fotos\n";
            Assert.AreEqual(expected, actual);
        }

        /// TEST PARA LA IMPRESORA COMPACTA

        [TestMethod()]
        public void imprimirInternacionalGallegoCompactaLambdaNTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "f Foto Espanha\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegoCompactaLambdaAConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Directorio directorio = new Directorio("Más fotos");
            String actual = impComp.imprimirDirectorio(directorio, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "d Mas fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegoCompactaLambdaEConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "f Foto Jose\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegoCompactaLambdaIConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "f Calibri fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegoCompactaLambdaOConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "f Grabacion Television\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegoCompactaLambdaUConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impComp.imprimirArchivoComprimido(archivoComprimido, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });
            String expected = "c Aun Fotos\n";
            Assert.AreEqual(expected, actual);
        }
    }
}