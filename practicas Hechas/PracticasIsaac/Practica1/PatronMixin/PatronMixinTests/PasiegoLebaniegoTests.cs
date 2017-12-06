using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronMixin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixin.Tests
{
    /**
     * <summary>
     * Clase de pruebas para la clase PasiegoLebaniego
     * </summary> 
     */
    [TestClass()]
    public class PasiegoLebaniegoTests
    {
        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerCocido
         * </summary> 
         */
        [TestMethod()]
        public void hacerCocidoTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego();
            String expected = "Haciendo Cocido";
            String actual = pasiegoLebaniego.hacerCocido();

            Assert.AreEqual(expected,actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerOrujo
         * </summary> 
         */
        [TestMethod()]
        public void hacerOrujoTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego();
            String expected = "Haciendo Orujo";
            String actual = pasiegoLebaniego.hacerOrujo();

            Assert.AreEqual(expected, actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerSobaos
         * </summary> 
         */
        [TestMethod()]
        public void hacerSobaosTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego();
            String expected = "Haciendo Sobaos";
            String actual = pasiegoLebaniego.hacerSobaos();

            Assert.AreEqual(expected, actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerQuesada
         * </summary> 
         */
        [TestMethod()]
        public void hacerQuesadaTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego();
            String expected = "Haciendo Quesada";
            String actual = pasiegoLebaniego.hacerQuesada();

            Assert.AreEqual(expected, actual);
        }
    }
}
