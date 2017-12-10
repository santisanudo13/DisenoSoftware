using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Fichero: IEnumerable<Fichero>
    {
        protected String nombre;
        protected List<Fichero> archivos = new List<Fichero>();

        protected List<FicheroObserver> observers = new List<FicheroObserver>();

        public Fichero(String name)
        {
            Nombre = name;
        }

        //public string Nombre { get => nombre; set => nombre = value; }
        public string Nombre
        {
            get {
                return nombre;
            }

            set
            {
                nombre = value;
                notify();
            }
        }
        public List<Fichero> Archivos { get => archivos; set => archivos = value; }

        public abstract float GetSize();
        public abstract int GetNArchivos();

        public abstract String AcceptPrinter(Printer p);

        public void registerObserver(FicheroObserver n)
        {
            observers.Add(n);
        }

        public void removeObserver(FicheroObserver n)
        {
            observers.Remove(n);
        }

        protected void notify()
        {
            foreach (FicheroObserver n in observers)
            {
                n.update(this);
            }
        }

        public abstract IEnumerator<Fichero> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
