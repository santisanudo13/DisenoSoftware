using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Comprimido : Directorio
    {

        public Comprimido(string name) : base(name) { }
        

        public override string AcceptPrinter(Printer p)
        {
            return p.printComprimido(this);
        }

        public override IEnumerator<Fichero> GetEnumerator()
        {
            return new IteratorDir(this);
        }

        public override int GetNArchivos()
        {
            return 1;
        }

        public new Fichero getRef()
        {
            return this;
        }

        public override float GetSize()
        {
            float temp = 0;
            if (Archivos.Count == 0)
            {
                temp = 0;
            }
            else
            {
                foreach(Fichero x in Archivos)
                {
                    temp += x.GetSize();
                }
                temp = temp*0.3f;
            }
            return temp;
            
        }
    }
}
