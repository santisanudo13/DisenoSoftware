using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Archivo : Fichero, ElementoRef
    {

        private float size;

        public Archivo(float size,String name):base(name)
        {
            Size = size;
        }

        public float Size { get => size; set => size = value; }

        public override string AcceptPrinter(Printer p)
        {
            return p.printArchivo(this);
        }

        public override IEnumerator<Fichero> GetEnumerator()
        {
            return new IteratorArch(this);
        }

        public override int GetNArchivos()
        {
            return 1;
        }

        public Fichero getRef()
        {
            return this;
        }

        public override float GetSize()
        {
            return Size;
        }
    }
}
