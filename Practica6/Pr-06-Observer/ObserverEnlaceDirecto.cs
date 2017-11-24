using CompositeSparrowEnlaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_06_Observer
{
    public class ObserverEnlaceDirecto : IObserver
    {
        private EnlaceDirecto enlaceDirecto;
        public ObserverEnlaceDirecto(EnlaceDirecto enlaceDirecto)
        {
            this.enlaceDirecto = enlaceDirecto;
        }
        public void update(Object o)
        {
            ElementoSistemaFicheros fichero = (ElementoSistemaFicheros)o;
            String name = fichero.Nombre;
            enlaceDirecto.Nombre = name;
        }
    }
}
