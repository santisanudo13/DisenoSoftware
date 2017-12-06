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
    /// Clase de Prubas de Directorio
    /// </summary>
    [TestClass()]
    public class DirectorioTests
    {
        private ArchivoComprimido archivoComprimido;
        private Archivo archivo;
        private Directorio directorio;
        private EnlaceDirecto enlace;

        [TestMethod()]
        public void calcularTamanyoVacioTest()
        {
            directorio = new Directorio("carpeta pepe");

            double expected = 1;
            double actual = directorio.calcularTamanyo();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void numArchivosVacioTest()
        {
            directorio = new Directorio("carpeta pepe");

            int expected = 0;
            int actual = directorio.numArchivos();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void calcularTamanyoUNElementoTest()
        {
            directorio = new Directorio("carpeta pepe");
            archivo = new Archivo("archivo1.pdf", 30);

            directorio.anadeElemento(archivo);

            double expected = 30 + 1;
            double actual = directorio.calcularTamanyo();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void numArchivosUNElementoTest()
        {
            directorio = new Directorio("carpeta pepe");
            archivo = new Archivo("archivo1.pdf", 30);

            directorio.anadeElemento(archivo);

            int expected = 1;
            int actual = directorio.numArchivos();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void calcularTamanyoDOSoMASElementosTest()
        {
            archivoComprimido = new ArchivoComprimido("comprimido1.zip");
            archivo = new Archivo("archivo1.pdf", 30);
            directorio = new Directorio("carpeta pepe");
            enlace = new EnlaceDirecto(archivo);

            directorio.anadeElemento(archivo);
            directorio.anadeElemento(archivoComprimido);
            archivoComprimido.anadeElemento(archivo);
            directorio.anadeElemento(enlace);

            double expected = 30 + 1 + 30 * 0.3 + 1;
            double actual = directorio.calcularTamanyo();

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
            directorio.anadeElemento(archivoComprimido);
            directorio.anadeElemento(enlace);

            int expected = 2;
            int actual = directorio.numArchivos();

            Assert.AreEqual(actual, expected);
        }

    }
}