using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class EstadoIterator
    {
        protected IteratorDir original;
        
        public EstadoIterator(IteratorDir t)
        {
            original = t;
        }
        public abstract bool moveNext();
    }
}
