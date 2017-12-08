using System;
using System.Collections.Generic;
using System.Text;

namespace Practica3
{
    class Archivo : ElementoSistemaFicheros
    {
        private double size;
        public double Size { get => size; set => size = value; }
        public Archivo(string nombre, double size) : base(nombre)
        {
            base.Nombre = nombre;
            Size = size;
        }

        public override string accept(Visitor visitor)
        {
            return visitor.visitArchivo(this);
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
