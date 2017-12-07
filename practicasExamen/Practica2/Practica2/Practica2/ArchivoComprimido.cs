using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    class ArchivoComprimido : ElementoSistemaFicheros, IContenedor
    {
        private IList<ElementoSistemaFicheros> elementosContenidos;
        private  readonly double factorCompresion = 0.3;

        public IList<ElementoSistemaFicheros> ElementosContenidos { get => elementosContenidos; set => elementosContenidos = value; }
        public double FactorCompresion { get => factorCompresion; }

        public ArchivoComprimido(string nombre, double size) : base(nombre, size)
        {
            
            base.Nombre = nombre;
            ElementosContenidos = new List<ElementoSistemaFicheros>();

            double sizeCounter = 0;
            foreach(ElementoSistemaFicheros file in ElementosContenidos)
            {
                sizeCounter = sizeCounter + file.Size;
            }
            base.Size = sizeCounter * FactorCompresion;
        }

        public override double totalSize()
        {
            double sizeCounter = 0;
            foreach (ElementoSistemaFicheros file in ElementosContenidos)
            {
                sizeCounter = sizeCounter + file.Size;
            }
            return sizeCounter * FactorCompresion; 
        }

        public override int totalFiles()
        {
            return 1;
        }

        public bool addElement(ElementoSistemaFicheros file)
        {
            if(!ElementosContenidos.Contains(file))
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
