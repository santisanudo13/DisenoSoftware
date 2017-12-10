using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class PrintExtendido: Printer
    {
        public override string printArchivo(Archivo e)
        {
            return "f " + e.Nombre + "\n";
        }

        public override string printComprimido(Comprimido e)
        {
            string s ="c "+ e.Nombre + "\n";
            tabulado += "   ";
            foreach (Fichero f in e.Archivos)
            {
                s += tabulado + f.AcceptPrinter(this);
            }
            tabulado = tabulado.Substring(0, tabulado.Length - 3);

            return s;
        }

        public override string printDirectorio(Directorio e)
        {
            string s = "d "+e.Nombre + "\n";
            tabulado += "   ";
            foreach (Fichero f in e.Archivos)
            {
                s += tabulado + f.AcceptPrinter(this);
            }
            tabulado = tabulado.Substring(0, tabulado.Length - 3);

            return s;

        }

        public override string printEnlace(Enlace e)
        {
            return "e "+ e.Nombre + "\n";
        }
    }
}
