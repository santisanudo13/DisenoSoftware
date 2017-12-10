using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Enlace : Fichero, FicheroObserver
    {
        const float definicion = 1;

        Fichero refer;
        public Enlace(string name,ElementoRef ele) : base(name)
        {
            refer = ele.getRef();
            refer.registerObserver(this);
        }

        public override string AcceptPrinter(Printer p)
        {
            return p.printEnlace(this);
        }

        public override IEnumerator<Fichero> GetEnumerator()
        {
            return new IteratorEnla(this);
        }

        public override int GetNArchivos()
        {
            return 1;
        }

        public override float GetSize()
        {
            return definicion;
        }

        public void update(Fichero f)
        {
            this.Nombre = f.Nombre;
        }
    }
}
