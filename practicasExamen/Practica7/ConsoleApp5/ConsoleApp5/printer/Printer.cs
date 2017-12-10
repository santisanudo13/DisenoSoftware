using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Printer
    {
        protected string tabulado="";
        public abstract string printArchivo(Archivo e);
        public abstract string printDirectorio(Directorio e);
        public abstract string printComprimido(Comprimido e);
        public abstract string printEnlace(Enlace e);
    }
}
