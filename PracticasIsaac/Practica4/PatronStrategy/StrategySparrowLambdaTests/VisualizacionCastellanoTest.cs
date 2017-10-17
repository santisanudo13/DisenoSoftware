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
    /// Pruebas para la estrategia de visualizacion en castellano
    /// </summary>
    [TestClass()]
    public class VisualizacionCastellanoTest
    {
        ImpresoraExtendida impExt;
        ImpresoraCompacta impComp;

        String[] castellano = { "ñ", "á", "é", "í", "ó", "ú" };

        /// TEST PARA LA IMPRESORA EXTENDIDA

        [TestMethod()]
        public void imprimirCastellanoExtendidaLambdaNTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "f Foto España\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoExtendidaLambdaAConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Directorio directorio = new Directorio("Más fotos");
            String actual = impExt.imprimirDirectorio(directorio, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "d Más fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoExtendidaLambdaEConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "f Foto José\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoExtendidaLambdaIConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "f Calibrí fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoExtendidaLambdaOConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "f Grabación Televisión\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoExtendidaLambdaUConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impExt.imprimirArchivoComprimido(archivoComprimido, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "c Aún Fotos\n";
            Assert.AreEqual(expected, actual);
        }

        /// TEST PARA LA IMPRESORA COMPACTA

        [TestMethod()]
        public void imprimirCastellanoCompactaLambdaNTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "f Foto España\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoCompactaLambdaAConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Directorio directorio = new Directorio("Más fotos");
            String actual = impComp.imprimirDirectorio(directorio, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "d Más fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoCompactaLambdaEConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "f Foto José\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoCompactaLambdaIConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "f Calibrí fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoCompactaLambdaOConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "f Grabación Televisión\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoCompactaLambdaUConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impComp.imprimirArchivoComprimido(archivoComprimido, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });
            String expected = "c Aún Fotos\n";
            Assert.AreEqual(expected, actual);
        }
    }
}