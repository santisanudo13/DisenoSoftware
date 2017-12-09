using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    abstract class ElementoSistemaFicheros: PropiedadesSistemaFicheros, IEnlazable
    {
        private String nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        

        public ElementoSistemaFicheros(string nombre)
        {
            Nombre = nombre;
        }

        public abstract double totalSize();
        public abstract int totalFiles();

        public abstract String accept(Visitor visitor);

    }
}
