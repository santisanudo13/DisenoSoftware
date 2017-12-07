using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    class EnlaceDirecto : ElementoSistemaFicheros
    {

        IEnlazable elementoDestino;
        public IEnlazable ElementoDestino { get => elementoDestino; set => elementoDestino = value; }


        public EnlaceDirecto(string nombre, double size, IEnlazable elementoDestino) : base(nombre, size)
        {
            base.Nombre = elementoDestino.Nombre;
            base.Size = 1;
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
    }
}
