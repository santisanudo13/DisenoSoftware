using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategySparrow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace StrategySparrow.Tests
{
    /// <summary>
    /// Puebas para la visualizacion Catalana
    /// </summary>
    [TestClass()]
    public class VisualizacionCatalanaTests
    {
        ImpresoraExtendida impExt;
        ImpresoraCompacta impComp;
        VisualizacionCatalana visualizacionCatalana = new VisualizacionCatalana();

        /// TEST PARA LA IMPRESORA EXTENDIDA

        [TestMethod()]
        public void imprimirCatalanaExtendidaNTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCatalana);
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Foto Espanya\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanaExtendidaAConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCatalana);
            Directorio directorio = new Directorio("Más fotos");
            String actual = impExt.imprimirDirectorio(directorio);
            String expected = "d Más fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanaExtendidaEConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCatalana);
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Foto José\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanaExtendidaIConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCatalana);
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Calibrí fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanaExtendidaOConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCatalana);
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Grabación Televisión\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanaExtendidaUConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCatalana);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impExt.imprimirArchivoComprimido(archivoComprimido);
            String expected = "c Aún Fotos\n";
            Assert.AreEqual(expected, actual);
        }

        /// TEST PARA LA IMPRESORA COMPACTA

        [TestMethod()]
        public void imprimirCatalanaCompactaNTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCatalana);
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Foto Espanya\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanaCompactaAConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCatalana);
            Directorio directorio = new Directorio("Más fotos");
            String actual = impComp.imprimirDirectorio(directorio);
            String expected = "d Más fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanaCompactaEConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCatalana);
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Foto José\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanaCompactaIConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCatalana);
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Calibrí fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanaCompactaOConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCatalana);
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Grabación Televisión\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCatalanaCompactaUConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCatalana);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impComp.imprimirArchivoComprimido(archivoComprimido);
            String expected = "c Aún Fotos\n";
            Assert.AreEqual(expected, actual);
        }
    }
}