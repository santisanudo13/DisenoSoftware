using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Final : EstadoIterator
    {
        public Final(IteratorDir t) : base(t)
        {
        }

        public override bool moveNext()
        {
            return false;
        }
    }
}
