using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Creado : EstadoIterator
    {
        public Creado(IteratorDir t) : base(t)
        {
        }

        public override bool moveNext()
        {
            this.original.current= this.original.raiz;
            moveToNext();
            return true;
        }
        private void moveToNext()
        {
            original.estado = new EnRaiz(original);
        }
    }
}
