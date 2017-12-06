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
    /// Puebas para la visualizacion InternacionalGallega
    /// </summary>
    [TestClass()]
    public class VisualizacionInternacionalGallegaTests
    {
        ImpresoraExtendida impExt;
        ImpresoraCompacta impComp;
        VisualizacionInternacionalGallega visualizacionInternacionalGallega = new VisualizacionInternacionalGallega();

        /// TEST PARA LA IMPRESORA EXTENDIDA

        [TestMethod()]
        public void imprimirInternacionalGallegaExtendidaNTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalGallega);
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Foto Espanha\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegaExtendidaAConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalGallega);
            Directorio directorio = new Directorio("Más fotos");
            String actual = impExt.imprimirDirectorio(directorio);
            String expected = "d Mas fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegaExtendidaEConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalGallega);
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Foto Jose\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegaExtendidaIConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalGallega);
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Calibri fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegaExtendidaOConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalGallega);
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Grabacion Television\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegaExtendidaUConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionInternacionalGallega);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impExt.imprimirArchivoComprimido(archivoComprimido);
            String expected = "c Aun Fotos\n";
            Assert.AreEqual(expected, actual);
        }

        /// TEST PARA LA IMPRESORA COMPACTA

        [TestMethod()]
        public void imprimirInternacionalGallegaCompactaNTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalGallega);
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Foto Espanha\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegaCompactaAConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalGallega);
            Directorio directorio = new Directorio("Más fotos");
            String actual = impComp.imprimirDirectorio(directorio);
            String expected = "d Mas fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegaCompactaEConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalGallega);
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Foto Jose\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegaCompactaIConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalGallega);
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Calibri fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegaCompactaOConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalGallega);
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Grabacion Television\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirInternacionalGallegaCompactaUConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionInternacionalGallega);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impComp.imprimirArchivoComprimido(archivoComprimido);
            String expected = "c Aun Fotos\n";
            Assert.AreEqual(expected, actual);
        }
    }
}