using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica1;

namespace Practica1Test
{
    [TestClass]
    public class PasiegoLebaniegoTest
    {
        [TestMethod]
        public void hacerQuesada()
        {
            PasiegoLebaniego pasLeb = new PasiegoLebaniego(TipoContexto.LIEBANA, new Pasiego(), new Lebaniego());
            StringAssert.Equals(pasLeb.hacerQuesada(), "Haciendo Quesada");
        }

        [TestMethod]
        public void hacerSobaos()
        {
            PasiegoLebaniego pasLeb = new PasiegoLebaniego(TipoContexto.LIEBANA, new Pasiego(), new Lebaniego());
            StringAssert.Equals(pasLeb.hacerSobaos(), "Haciendo Sobaos");
        }

        [TestMethod]
        public void hacerOrujoTest()
        {
            PasiegoLebaniego pasLeb = new PasiegoLebaniego(TipoContexto.LIEBANA, new Pasiego(), new Lebaniego());
            StringAssert.Equals(pasLeb.hacerOrujo(), "Haciendo Orujo");
        }

        [TestMethod]
        public void hacerCocidoTest()
        {
            PasiegoLebaniego pasLeb = new PasiegoLebaniego(TipoContexto.LIEBANA, new Pasiego(), new Lebaniego());
            StringAssert.Equals(pasLeb.hacerCocido(), "Haciendo Cocido Lebaniego");

            pasLeb.Contexto = TipoContexto.PAS;
            StringAssert.Equals(pasLeb.hacerCocido(), "Haciendo Cocido Pasiego");
        }
    }

   
}
