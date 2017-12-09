using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class VisitorCompacto : Visitor
    {
        private int nivel = 0;

        public VisitorCompacto(Tipografia tipografia) : base(tipografia)
        {
            base.Tipografia = tipografia;
        }

        private String anadirTabulacio(int nivelAnidamiento)
        {
            String str = "";
            for (int i = 0; i < nivelAnidamiento; i++)
            {
                str = str + "   ";
            }
            return str;
        }


        public override string visitArchivo(Archivo file)
        {
            return Tipografia.convertir("f " + file.Nombre + "\n");
        }

        public override string visitArchivoComprimido(ArchivoComprimido file)
        {
            return Tipografia.convertir("c " + file.Nombre + "\n");
        }

        public override string visitDirectorio(Directorio file)
        {
            String str = "d " + file.Nombre + "\n";
            nivel++;
            foreach (ElementoSistemaFicheros e in file.ElementosContenidos)
            {
                str = str + anadirTabulacio(nivel) + e.accept(this);
            }
            nivel--;
            return Tipografia.convertir(str);
        }

        public override string visitEnlaceDirecto(EnlaceDirecto file)
        {
            return Tipografia.convertir("e " + file.Nombre + "\n");
        }
    }
}
