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
            String name = (String)o;
            enlaceDirecto.Nombre = name;
        }
    }
}
