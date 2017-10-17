using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompositeSparrowEnlaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Isaac Gutierrez Rodriguez
namespace CompositeSparrowEnlaces.Tests
{
    /// <summary>
    /// Clase de Prubas de Archivo
    /// </summary>
    [TestClass()]
    public class ArchivoTests
    {
        private Archivo archivo;

        [TestMethod()]
        public void calcularTamanyoArchivoTest()
        {
            archivo = new Archivo("pepe.doc", 5);

            Console.Out.WriteLine(archivo.calcularTamanyo());

            double expected = 5;
            double actual = archivo.calcularTamanyo();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void numArchivosArchivoTest()
        {
            archivo = new Archivo("pepe.pdf", 3);

            int expected = 1;
            int actual = archivo.numArchivos();

            Assert.AreEqual(actual, expected);
        }
    }
}