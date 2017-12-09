using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    class TipografiaGallega : Tipografia
    {
        public override string convertir(String input)
        {
            return input.Replace("ñ", "nh");
        }
    }
}
