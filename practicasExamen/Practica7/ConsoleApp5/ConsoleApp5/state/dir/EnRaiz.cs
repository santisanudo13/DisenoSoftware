using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class EnRaiz : EstadoIterator
    {
        public EnRaiz(IteratorDir t) : base(t)
        {
        }

        public override bool moveNext()
        {
            bool moved = false;
           
                // Obtenemos un iterador para los hijos. 
                // NOTA: Items nunca puede ser null, en caso de no tener hijos, sería 
                // un conjunto vacío.
            original.childIterator = original.raiz.Archivos.GetEnumerator();
                // Intentamos avanzar el iterador de los hijos para colocarlo en el primer
                // hijo, ya que en el caso de que la lista no tenga hijos, este iterador
                // no se podría avanzar nunca
            if (original.childIterator.MoveNext())
            {
                    // Si hay algún hijo, colocamos el iterador de los hijos apuntando al 
                    // primer no del árbol correspondondiente a dicho hijo
                original.iniatilizeIteratorOverChild();
                    // Además, indicamos que hemos tenido éxito y nos hemos movido.
                moved = true;
                moveToNext();
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

        private void moveToNext()
        {
            original.estado = new EnHijo(original);
        }
    }
}
