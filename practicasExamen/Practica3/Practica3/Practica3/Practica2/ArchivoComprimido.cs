using System;
using System.Collections.Generic;
using System.Text;

namespace Practica3
{
    class ArchivoComprimido : ElementoSistemaFicheros, IContenedor
    {
        private double size;
        public double Size { get => size; set => size = value; }
        private readonly double factorCompresion = 0.3;

        private IList<ElementoSistemaFicheros> elementosContenidos;

        public IList<ElementoSistemaFicheros> ElementosContenidos { get => elementosContenidos; set => elementosContenidos = value; }
        public double FactorCompresion { get => factorCompresion; }

        public ArchivoComprimido(string nombre) : base(nombre)
        {
            
            base.Nombre = nombre;
            ElementosContenidos = new List<ElementoSistemaFicheros>();

            double sizeCounter = 0;
            foreach(ElementoSistemaFicheros file in ElementosContenidos)
            {
                sizeCounter = sizeCounter + file.totalSize();
            }
            Size = sizeCounter * FactorCompresion;
        }

        public override double totalSize()
        {
            double sizeCounter = 0;
            foreach (ElementoSistemaFicheros file in ElementosContenidos)
            {
                sizeCounter = sizeCounter + file.totalSize();
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

        public override string accept(Visitor visitor)
        {
            return visitor.visitArchivoComprimido(this);
        }
    }
}
