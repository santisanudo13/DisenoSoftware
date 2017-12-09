using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    abstract class Visitor
    {
        Tipografia tipografia;

        internal Tipografia Tipografia { get => tipografia; set => tipografia = value; }

        public Visitor(Tipografia tipografia)
        {
            this.tipografia = tipografia;
        }

        public abstract String visitArchivo(Archivo file);
        public abstract String visitArchivoComprimido(ArchivoComprimido file);
        public abstract String visitDirectorio(Directorio file);
        public abstract String visitEnlaceDirecto(EnlaceDirecto file);

    }
}
