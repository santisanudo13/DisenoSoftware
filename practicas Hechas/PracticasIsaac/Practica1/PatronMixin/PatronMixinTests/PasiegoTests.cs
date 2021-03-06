﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
     * Clase de pruebas para la clase Pasiego
     * </summary> 
     */
    [TestClass()]
    public class PasiegoTests
    {

        /**
         * <summary>
         * Caso de prueba para la prueba del metodo hacerSobaos
         * </summary> 
         */
        [TestMethod()]
        public void hacerSobaosTest()
        {
            Pasiego pasiego = new Pasiego();
            String expected = "Haciendo Sobaos";
            String actual = pasiego.hacerSobaos();
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
            Pasiego pasiego = new Pasiego();
            String expected = "Haciendo Quesada";
            String actual = pasiego.hacerQuesada();
            Assert.AreEqual(expected, actual);
        }
    }
}