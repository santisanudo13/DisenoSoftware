using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica1;

namespace Practica1Test
{
    [TestClass]
    public class LebaniegoTest
    {
        [TestMethod]
        public void hacerOrujoTest()
        {
            Lebaniego leb = new Lebaniego();
            StringAssert.Equals(leb.hacerOrujo(), "Haciendo Orujo");
        }

        [TestMethod]
        public void hacerCocidoTest()
        {
            Lebaniego leb = new Lebaniego();
            StringAssert.Equals(leb.hacerCocido(), "Haciendo Cocido Lebaniego");
        }
    }

   
}
