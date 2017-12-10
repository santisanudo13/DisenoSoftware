using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class EnHijo : EstadoIterator
    {
        public EnHijo(IteratorDir t) : base(t)
        {
        }

        public override bool moveNext()
        {
            bool moved = false;
            if (original.currentIterator.MoveNext())
            {
                // Si hemos podido movernos, accedemos al elemento actual y hacemos que nuestra 
                // referencia current apunte a él
                original.current = original.currentIterator.Current;
                // Como nos hemos movido, lo señalamos
                moved = true;
            }
            /// Si el iterador de los hijos está inicializado, pero no nos podemos mover por 
            /// el iterador de los hijos, es porque el iterador del hijo actual se ha acabado e intentamos,
            /// por tanto, movernos al siguiente hijo. 
            else if (original.childIterator.MoveNext())
            {
                // Si hemos conseguido movernos al siguiente hijo, inicializamos el iterador para movernos 
                // por los nodos que correspondan al siguiente hijo.
                original.iniatilizeIteratorOverChild();
                // Como nos hemos movido, lo señalizamos.
                moved = true;
            }
            else
            {
                moveToFinal();
            }

            return moved;
        }
        private void moveToFinal()
        {
            original.estado = new Final(original);
        }
    }
}
