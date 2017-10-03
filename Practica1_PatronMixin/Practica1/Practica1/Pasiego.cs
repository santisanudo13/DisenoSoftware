using System;
namespace Practica1
{
    public class Pasiego:IPasiego
    {
        public Pasiego()
        {
        }

        public string hacerCocido()
        {
            return "Haciendo cocido Pasiego";
        }

        public string hacerQuesada()
        {
			return "Haciendo Quesada";
		}

        public string hacerSobaos()
        {
			return "Haciendo sobaos";
		}
    }
}
