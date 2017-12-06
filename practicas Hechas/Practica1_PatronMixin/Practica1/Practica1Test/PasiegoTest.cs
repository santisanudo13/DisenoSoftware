using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica1;

namespace Practica1Test
{
    [TestClass]
    public class PasiegoTest
    {
        [TestMethod]
        public void hacerQuesada()
        {
            Pasiego pas = new Pasiego();
            StringAssert.Equals(pas.hacerQuesada(), "Haciendo Quesada");
        }

        [TestMethod]
        public void hacerSobaos()
        {
            Pasiego pas = new Pasiego();
            StringAssert.Equals(pas.hacerSobaos(), "Haciendo Sobaos");
        }

        [TestMethod]
        public void hacerCocidoTest()
        {
            Pasiego pas = new Pasiego();
            StringAssert.Equals(pas.hacerCocido(), "Haciendo Cocido Pasiego");
        }
    }
}
