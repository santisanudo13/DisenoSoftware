using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronMixinContexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixinContexto.Tests
{
    /**
     * <summary>
     * Clase de pruebas para la clase Lebaniego
     * </summary> 
     */
    [TestClass()]
    public class LebaniegoTests
    {
        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerCocido
         * </summary> 
         */
        [TestMethod()]
        public void hacerCocidoTest()
        {
            Lebaniego lebaniego = new Lebaniego();
            String expected = "Haciendo Cocido Lebaniego";
            String actual = lebaniego.hacerCocido();
            Assert.AreEqual(expected, actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerOrujo
         * </summary> 
         */
        [TestMethod()]
        public void hacerOrujoTest()
        {
            Lebaniego lebaniego = new Lebaniego();
            String expected = "Haciendo Orujo";
            String actual = lebaniego.hacerOrujo();
            Assert.AreEqual(expected, actual);
        }
    }
}