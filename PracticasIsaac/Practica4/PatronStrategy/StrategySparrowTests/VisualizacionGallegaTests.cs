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
    /// Puebas para la visualizacion Gallega
    /// </summary>
    [TestClass()]
    public class VisualizacionGallegaTests
    {
        ImpresoraExtendida impExt;
        ImpresoraCompacta impComp;
        VisualizacionGallega visualizacionGallega = new VisualizacionGallega();

        /// TEST PARA LA IMPRESORA EXTENDIDA

        [TestMethod()]
        public void imprimirGallegaExtendidaNTest()
        {
            impExt = new ImpresoraExtendida(visualizacionGallega);
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Foto Espanha\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirGallegaExtendidaAConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionGallega);
            Directorio directorio = new Directorio("Más fotos");
            String actual = impExt.imprimirDirectorio(directorio);
            String expected = "d Más fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirGallegaExtendidaEConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionGallega);
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Foto José\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirGallegaExtendidaIConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionGallega);
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Calibrí fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirGallegaExtendidaOConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionGallega);
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Grabación Televisión\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirGallegaExtendidaUConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionGallega);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impExt.imprimirArchivoComprimido(archivoComprimido);
            String expected = "c Aún Fotos\n";
            Assert.AreEqual(expected, actual);
        }

        /// TEST PARA LA IMPRESORA COMPACTA

        [TestMethod()]
        public void imprimirGallegaCompactaNTest()
        {
            impComp = new ImpresoraCompacta(visualizacionGallega);
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Foto Espanha\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirGallegaCompactaAConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionGallega);
            Directorio directorio = new Directorio("Más fotos");
            String actual = impComp.imprimirDirectorio(directorio);
            String expected = "d Más fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirGallegaCompactaEConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionGallega);
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Foto José\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirGallegaCompactaIConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionGallega);
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Calibrí fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirGallegaCompactaOConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionGallega);
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Grabación Televisión\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirGallegaCompactaUConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionGallega);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impComp.imprimirArchivoComprimido(archivoComprimido);
            String expected = "c Aún Fotos\n";
            Assert.AreEqual(expected, actual);
        }
    }
}