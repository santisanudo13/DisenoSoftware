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
    /// Clase de Prubas de EnlaceDirecto
    /// 
    /// No se incluyen pruebas para:
    ///     1. Cambiar el nombre
    ///     2. Enlazar un enlace 
    /// ya que la propia estructura del software impide que estas operaciones
    /// puedan realizarse, por lo que provocaria errores en la compilacion
    /// 
    /// </summary>
    [TestClass()]
    public class EnlaceDirectoTests
    {

        private EnlaceDirecto enlace;
        private Archivo archivo;

        [TestMethod()]
        public void calcularTamanyoTest()
        {
            archivo = new Archivo("pepe.doc", 23);
            enlace = new EnlaceDirecto(archivo);

            double expected = 1;
            double actual = enlace.calcularTamanyo();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void numArchivosTest()
        {
            archivo = new Archivo("pepe.doc", 23);
            enlace = new EnlaceDirecto(archivo);

            double expected = 0;
            double actual = enlace.numArchivos();

            Assert.AreEqual(actual, expected);
        }
    }
}