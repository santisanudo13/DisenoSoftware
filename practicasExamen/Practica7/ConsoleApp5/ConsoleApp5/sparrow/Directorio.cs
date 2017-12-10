using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Directorio : Fichero, ElementoRef
    {
        const int definicion = 1;
        public Directorio(String name) : base(name) { }
        
        public override string AcceptPrinter(Printer p)
        {
            return p.printDirectorio(this);
        }

        public override IEnumerator<Fichero> GetEnumerator()
        {
            return new IteratorDir(this);
        }

        public override int GetNArchivos()
        {
            int resultado = 0;
            if (Archivos.Count == 0)
            {
                resultado=0;
            }
            else
            {
                foreach(Fichero x in Archivos)
                {
                    resultado += x.GetNArchivos();
                }
            }
            return resultado;
        }

        public Fichero getRef()
        {
            return this;
        }

        public override float GetSize()
        {
            float temp=0;
            if (Archivos.Count == 0)
            {
                temp = 0;
            }
            else
            {
                foreach (Fichero x in Archivos)
                {
                    temp += x.GetSize();

                }
            }
            
            return definicion + temp;
        }
    }
}
