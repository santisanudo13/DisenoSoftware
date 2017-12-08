using System;
using System.Collections.Generic;
using System.Text;

namespace Practica3
{
    class Directorio : ElementoSistemaFicheros, IContenedor
    {
        private IList<ElementoSistemaFicheros> elementosContenidos;
        public IList<ElementoSistemaFicheros> ElementosContenidos { get => elementosContenidos; set => elementosContenidos = value; }
        private double size;
        public double Size { get => size; set => size = value; }

        public Directorio(string nombre) : base(nombre)
        {
            base.Nombre = nombre;
            Size = 1;
            ElementosContenidos = new List<ElementoSistemaFicheros>();

        }


        public override double totalSize()
        {
            return Size;
        }

        public override int totalFiles()
        {
            int counter = 0;

            foreach(ElementoSistemaFicheros file in ElementosContenidos)
            {
                counter = counter + file.totalFiles();
            }

            return counter;
        }

        public bool addElement(ElementoSistemaFicheros file)
        {
            if (!ElementosContenidos.Contains(file))
            {
                ElementosContenidos.Add(file);
                return true;
            }
            return false;

        }

        public bool removeElement(ElementoSistemaFicheros file)
        {
            return ElementosContenidos.Remove(file);
        }

        public override string accept(Visitor visitor)
        {
            return visitor.visitDirectorio(this);
        }
    }
}
