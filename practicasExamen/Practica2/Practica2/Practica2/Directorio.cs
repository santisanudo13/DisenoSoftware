using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    class Directorio : ElementoSistemaFicheros, IContenedor
    {
        private IList<ElementoSistemaFicheros> elementosContenidos;
        public IList<ElementoSistemaFicheros> ElementosContenidos { get => elementosContenidos; set => elementosContenidos = value; }

        public Directorio(string nombre, double size) : base(nombre, size)
        {
            base.Nombre = nombre;
            base.Size = 1;
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
    }
}
