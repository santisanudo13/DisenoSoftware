using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    class Pasiego : IPasiego
    {
        public string hacerCocido()
        {
            return "Hacer cocido Pasiego";
        }

        public string hacerQuesada()
        {
            return "Hacer quesada";
        }

        public string hacerSobaos()
        {
            return "Hacer sobaos";
        }
    }
}
