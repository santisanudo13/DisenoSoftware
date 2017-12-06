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
    /// Puebas para la visualizacion Internacional Catalana
    /// </summary>
    [TestClass()]
    public class VisualizacionInternacionalCatalanaTests
    {
        ImpresoraExtendida impExt;
        ImpresoraCompacta impComp;
        VisualizacionInternacionalCatalana visualizacionInternacionalCatalana = new VisualizacionInternacionalCatalana();

        /// TEST PARA LA IMPRESORA EXTENDIDA

        [TestMethod()]
        public void imprimirInternacionalCatalanaExtendidaNTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalCatalana);
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Foto Espanya\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanaExtendidaAConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalCatalana);
            Directorio directorio = new Directorio("Más fotos");
            String actual = impExt.imprimirDirectorio(directorio);
            String expected = "d Mas fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanaExtendidaEConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalCatalana);
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Foto Jose\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanaExtendidaIConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalCatalana);
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Calibri fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanaExtendidaOConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalCatalana);
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Grabacion Television\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanaExtendidaUConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalCatalana);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impExt.imprimirArchivoComprimido(archivoComprimido);
            String expected = "c Aun Fotos\n";
            Assert.AreEqual(expected, actual);
        }

        /// TEST PARA LA IMPRESORA COMPACTA

        [TestMethod()]
        public void imprimirInternacionalCatalanaCompactaNTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalCatalana);
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Foto Espanya\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanaCompactaAConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalCatalana);
            Directorio directorio = new Directorio("Más fotos");
            String actual = impComp.imprimirDirectorio(directorio);
            String expected = "d Mas fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanaCompactaEConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalCatalana);
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Foto Jose\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanaCompactaIConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalCatalana);
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Calibri fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanaCompactaOConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalCatalana);
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Grabacion Television\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalCatalanaCompactaUConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalCatalana);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impComp.imprimirArchivoComprimido(archivoComprimido);
            String expected = "c Aun Fotos\n";
            Assert.AreEqual(expected, actual);
        }
    }
}