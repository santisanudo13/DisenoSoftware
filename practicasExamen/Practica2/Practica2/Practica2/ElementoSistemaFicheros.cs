using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    abstract class ElementoSistemaFicheros: PropiedadesSistemaFicheros, IEnlazable
    {
        private String nombre;
        private double size;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Size { get => size; set => size = value; }

        public ElementoSistemaFicheros(string nombre, double size)
        {
            Nombre = nombre;
            Size = size;
        }

        public abstract double totalSize();
        public abstract int totalFiles();
    }
}
