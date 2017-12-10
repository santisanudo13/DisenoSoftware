using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class IteratorArch : IEnumerator<Fichero>
    {
        protected Fichero current = null;

        protected Archivo elemento;

        public Fichero Current
        {
            get
            {
                return current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.current;
            }
        }

        public IteratorArch(Archivo cl)
        {
            this.elemento = cl;
        }

        public void Dispose()
        { }

        public bool MoveNext()
        {
            bool moved = false;
            
            if (current == null)
            {
                current = elemento;
                moved = true;
            }
            return moved;
        }

        public void Reset()
        {
            current = null;
            
        }
    }
}
