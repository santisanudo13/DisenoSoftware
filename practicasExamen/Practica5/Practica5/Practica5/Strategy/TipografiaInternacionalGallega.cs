using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class TipografiaInternacionalGallega : Tipografia
    {
        public override string convertir(string input)
        {
            input = input.Replace("ñ", "nh");
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
