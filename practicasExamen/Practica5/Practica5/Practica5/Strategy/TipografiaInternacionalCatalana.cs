using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class TipografiaInternacionalCatalana : Tipografia
    {
        public override string convertir(String input)
        {
            input = input.Replace("ñ", "ny");
            input = input.Replace("á", "a");
            input = input.Replace("ú", "u");
            input = input.Replace("í", "i");
            input = input.Replace("ó", "o");
            input = input.Replace("é", "e");

            return input;
        }
        public override object clone()
        {
            return this.MemberwiseClone();
        }

    }
}
