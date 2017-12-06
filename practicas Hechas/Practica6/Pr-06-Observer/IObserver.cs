using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_06_Observer
{
    public interface IObserver
    {
        void update(Object o);
    }
}
