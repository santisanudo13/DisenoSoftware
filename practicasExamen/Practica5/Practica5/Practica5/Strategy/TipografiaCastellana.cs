using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class TipografiaCastellana : Tipografia
    {
        public override object clone()
        {
            return this.MemberwiseClone();
        }

        public override string convertir(String input)
        {
            return input;
        }
    }
}
