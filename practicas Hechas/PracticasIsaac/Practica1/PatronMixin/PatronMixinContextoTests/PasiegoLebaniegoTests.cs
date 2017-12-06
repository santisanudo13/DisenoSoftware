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
     * Clase de pruebas para la clase PasiegoLebaniego
     * </summary> 
     */
    [TestClass()]
    public class PasiegoLebaniegoTests
    {
        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerCocido con contexto PAS
         * </summary> 
         */
        [TestMethod()]
        public void hacerCocidoContextoPasTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego(TipoContexto.PAS);
            String expected = "Haciendo Cocido Montanes";
            String actual = pasiegoLebaniego.hacerCocido();

            Assert.AreEqual(expected, actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerOrujo con contexto PAS
         * </summary> 
         */
        [TestMethod()]
        public void hacerOrujoContextoPasTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego(TipoContexto.PAS);
            String expected = "Haciendo Orujo";
            String actual = pasiegoLebaniego.hacerOrujo();

            Assert.AreEqual(expected, actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerSobaos con contexto PAS
         * </summary> 
         */
        [TestMethod()]
        public void hacerSobaosContextoPasTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego(TipoContexto.PAS);
            String expected = "Haciendo Sobaos";
            String actual = pasiegoLebaniego.hacerSobaos();

            Assert.AreEqual(expected, actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerQuesada con contexto PAS
         * </summary> 
         */
        [TestMethod()]
        public void hacerQuesadaContextoPasTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego(TipoContexto.PAS);
            String expected = "Haciendo Quesada";
            String actual = pasiegoLebaniego.hacerQuesada();

            Assert.AreEqual(expected, actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerCocido con contexto Liebana
         * </summary> 
         */
        [TestMethod()]
        public void hacerCocidoContextoLiebanaTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego(TipoContexto.LIEBANA);
            String expected = "Haciendo Cocido Lebaniego";
            String actual = pasiegoLebaniego.hacerCocido();

            Assert.AreEqual(expected, actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerOrujo con contexto Liebana
         * </summary> 
         */
        [TestMethod()]
        public void hacerOrujoContextoLiebanaTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego(TipoContexto.LIEBANA);
            String expected = "Haciendo Orujo";
            String actual = pasiegoLebaniego.hacerOrujo();

            Assert.AreEqual(expected, actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerSobaos con contexto Liebana
         * </summary> 
         */
        [TestMethod()]
        public void hacerSobaosContextoLiebanaTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego(TipoContexto.LIEBANA);
            String expected = "Haciendo Sobaos";
            String actual = pasiegoLebaniego.hacerSobaos();

            Assert.AreEqual(expected, actual);
        }

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerQuesada con contexto Liebana
         * </summary> 
         */
        [TestMethod()]
        public void hacerQuesadaContextoLiebanaTest()
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego(TipoContexto.LIEBANA);
            String expected = "Haciendo Quesada";
            String actual = pasiegoLebaniego.hacerQuesada();

            Assert.AreEqual(expected, actual);
        }
    }
}