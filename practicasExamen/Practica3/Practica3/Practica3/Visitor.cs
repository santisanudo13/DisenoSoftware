using System;
using System.Collections.Generic;
using System.Text;

namespace Practica3
{
    abstract class Visitor
    {

        public abstract String visitArchivo(Archivo file);
        public abstract String visitArchivoComprimido(ArchivoComprimido file);
        public abstract String visitDirectorio(Directorio file);
        public abstract String visitEnlaceDirecto(EnlaceDirecto file);

    }
}
