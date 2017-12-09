using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    class EnlaceDirecto : ElementoSistemaFicheros
    {

        IEnlazable elementoDestino;
        public IEnlazable ElementoDestino { get => elementoDestino; set => elementoDestino = value; }
        private double size;
        public double Size { get => size; set => size = value; }

        public EnlaceDirecto(IEnlazable elementoDestino, String nombre) : base(nombre)
        {
            base.Nombre = elementoDestino.Nombre;
            Size = 1;
            ElementoDestino = elementoDestino;
        }

        public override double totalSize()
        {
            return Size;
        }

        public override int totalFiles()
        {
            return 0;
        }

        public override string accept(Visitor visitor)
        {
            return visitor.visitEnlaceDirecto(this);

        }
    }
}
