using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class IteratorDir : IEnumerator<Fichero>
    {
        public Fichero current = null;

        public EstadoIterator estado;

        public Directorio raiz;

      
        public IEnumerator<Fichero> childIterator = null;

     
        public IEnumerator<Fichero> currentIterator = null;

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

        public IteratorDir(Directorio cl)
        {
            this.raiz = cl;
            estado = new Creado(this);
        }

        public void Dispose()
        { }

        public bool MoveNext()
        {
            return estado.moveNext();
        }

        public void Reset()
        {
            current = null;
            childIterator = null;
        }
        public void iniatilizeIteratorOverChild()
        {
            currentIterator = childIterator.Current.GetEnumerator();
            currentIterator.MoveNext();
            current = currentIterator.Current;
        }
    }
}
