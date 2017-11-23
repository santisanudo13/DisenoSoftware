using CompositeSparrowEnlaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_06_Observer
{
    public class ObserverNode : IObserver
    {
        private SparrowNode sparrowNode;
        public ObserverNode(SparrowNode sparrowNode)
        {
            this.sparrowNode = sparrowNode;
        }
        public void update(Object o)
        {
            String name = (String)o;
            sparrowNode.Text = name;
        }
    }
}
