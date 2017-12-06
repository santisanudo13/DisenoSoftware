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
    /// Puebas para la visualizacion en Castellano
    /// </summary>
    [TestClass()]
    public class VisualizacionCastellanoTest
    {

        ImpresoraExtendida impExt;
        ImpresoraCompacta impComp;
        VisualizacionCastellano visualizacionCastellano = new VisualizacionCastellano();

        /// TEST PARA LA IMPRESORA EXTENDIDA

        [TestMethod()]
        public void imprimirCastellanoExtendidaNTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCastellano);
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Foto España\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoExtendidaAConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCastellano);
            Directorio directorio = new Directorio("Más fotos");
            String actual = impExt.imprimirDirectorio(directorio);
            String expected = "d Más fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoExtendidaEConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCastellano);
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Foto José\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoExtendidaIConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCastellano);
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Calibrí fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoExtendidaOConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCastellano);
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impExt.imprimirArchivo(archivo);
            String expected = "f Grabación Televisión\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoExtendidaUConTildeTest()
        {
            impExt = new ImpresoraExtendida(visualizacionCastellano);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impExt.imprimirArchivoComprimido(archivoComprimido);
            String expected = "c Aún Fotos\n";
            Assert.AreEqual(expected, actual);
        }

        /// TEST PARA LA IMPRESORA COMPACTA

        [TestMethod()]
        public void imprimirCastellanoCompactaNTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCastellano);
            Archivo archivo = new Archivo("Foto España", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Foto España\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoCompactaAConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCastellano);
            Directorio directorio = new Directorio("Más fotos");
            String actual = impComp.imprimirDirectorio(directorio);
            String expected = "d Más fotos\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoCompactaEConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCastellano);
            Archivo archivo = new Archivo("Foto José", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Foto José\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoCompactaIConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCastellano);
            Archivo archivo = new Archivo("Calibrí fuente", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Calibrí fuente\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoCompactaOConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCastellano);
            Archivo archivo = new Archivo("Grabación Televisión", 2);
            String actual = impComp.imprimirArchivo(archivo);
            String expected = "f Grabación Televisión\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void imprimirCastellanoCompactaUConTildeTest()
        {
            impComp = new ImpresoraCompacta(visualizacionCastellano);
            ArchivoComprimido archivoComprimido = new ArchivoComprimido("Aún Fotos");
            String actual = impComp.imprimirArchivoComprimido(archivoComprimido);
            String expected = "c Aún Fotos\n";
            Assert.AreEqual(expected, actual);
        }
    }
}