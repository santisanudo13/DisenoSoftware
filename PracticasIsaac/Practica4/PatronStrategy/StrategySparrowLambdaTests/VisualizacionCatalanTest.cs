﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    /// Pruebas para la estrategia de visualizacion en catalan
    /// </summary>
    [TestClass()]
    public class VisualizacionCatalanTest
    {
        ImpresoraExtendida impExt;
        ImpresoraCompacta impComp;

        String[] castellano = { "ñ", "á", "é", "í", "ó", "ú" };
        String[] catalan = { "ny", "á", "é", "í", "ó", "ú" };

        /// TEST PARA LA IMPRESORA EXTENDIDA

        [TestMethod()]
        public void imprimirCatalanExtendidaLambdaNTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "f Foto Espanya\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanExtendidaLambdaAConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Directorio directorio = new Directorio("Más fotos");
            String actual = impExt.imprimirDirectorio(directorio, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "d Más fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanExtendidaLambdaEConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "f Foto José\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanExtendidaLambdaIConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "f Calibrí fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanExtendidaLambdaOConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impExt.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "f Grabación Televisión\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanExtendidaLambdaUConTildeTest()
        {
            impExt = new ImpresoraExtendida();
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impExt.imprimirArchivoComprimido(archivoComprimido, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "c Aún Fotos\n";
            Assert.AreEqual(expected, actual);
        }

        /// TEST PARA LA IMPRESORA COMPACTA

        [TestMethod()]
        public void imprimirCatalanCompactaLambdaNTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "f Foto Espanya\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanCompactaLambdaAConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Directorio directorio = new Directorio("Más fotos");
            String actual = impComp.imprimirDirectorio(directorio, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "d Más fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanCompactaLambdaEConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "f Foto José\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanCompactaLambdaIConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "f Calibrí fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanCompactaLambdaOConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impComp.imprimirArchivo(archivo, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "f Grabación Televisión\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanCompactaLambdaUConTildeTest()
        {
            impComp = new ImpresoraCompacta();
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impComp.imprimirArchivoComprimido(archivoComprimido, (str) =>
            {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });
            String expected = "c Aún Fotos\n";
            Assert.AreEqual(expected, actual);
        }
    }
}