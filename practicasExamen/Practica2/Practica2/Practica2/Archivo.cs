using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    class Archivo : ElementoSistemaFicheros
    {
        public Archivo(string nombre, double size) : base(nombre, size)
        {
            base.Nombre = nombre;
            base.Size = size;
        }

        public override int totalFiles()
        {
            return 1;
        }

        public override double totalSize()
        {
            return Size;
        }
    }
}
