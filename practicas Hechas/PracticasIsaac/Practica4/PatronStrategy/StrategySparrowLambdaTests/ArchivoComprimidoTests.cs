using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategySparrowLambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Isaac Gutierrez Rodriguez
namespace StrategySparrowLambda.Tests
{
    /// <summary>
    /// Clase de Prubas de ArchivoComprimido
    /// </summary>
    [TestClass()]
    public class ArchivoComprimidoTests
    {
        private ArchivoComprimido archivoComprimido;
        private Archivo archivo;
        private Directorio directorio;
        private EnlaceDirecto enlace;

        [TestMethod()]
        public void calcularTamanyoVacioTest()
        {
            archivoComprimido = new ArchivoComprimido("comprimido1.zip");

            double expected = 0;
            double actual = archivoComprimido.calcularTamanyo();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void numArchivosVacioTest()
        {
            archivoComprimido = new ArchivoComprimido("comprimido1.zip");

            int expected = 1;
            int actual = archivoComprimido.numArchivos();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void calcularTamanyoUNElementoTest()
        {
            archivoComprimido = new ArchivoComprimido("comprimido1.zip");
            archivo = new Archivo("archivo1.pdf", 30);

            archivoComprimido.anadeElemento(archivo);

            double expected = 30 * 0.3;
            double actual = archivoComprimido.calcularTamanyo();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void numArchivosUNElementoTest()
        {
            archivoComprimido = new ArchivoComprimido("comprimido1.zip");
            archivo = new Archivo("archivo1.pdf", 30);

            archivoComprimido.anadeElemento(archivo);

            int expected = 1;
            int actual = archivoComprimido.numArchivos();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void calcularTamanyoDOSoMASElementosTest()
        {
            archivoComprimido = new ArchivoComprimido("comprimido1.zip");
            archivo = new Archivo("archivo1.pdf", 30);
            directorio = new Directorio("carpeta pepe");
            enlace = new EnlaceDirecto(archivo);

            archivoComprimido.anadeElemento(archivo);
            archivoComprimido.anadeElemento(directorio);
            archivoComprimido.anadeElemento(enlace);

            double expected = (1 + 30 + 1) * 0.3;
            double actual = archivoComprimido.calcularTamanyo();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void numArchivosDOSoMASElementosTest()
        {
            archivoComprimido = new ArchivoComprimido("comprimido1.zip");
            archivo = new Archivo("archivo1.pdf", 30);
            directorio = new Directorio("carpeta pepe");
            enlace = new EnlaceDirecto(archivo);

            directorio.anadeElemento(archivo);

            archivoComprimido.anadeElemento(archivo);
            archivoComprimido.anadeElemento(directorio);
            archivoComprimido.anadeElemento(enlace);

            int expected = 1;
            int actual = archivoComprimido.numArchivos();

            Assert.AreEqual(actual, expected);
        }
    }
}