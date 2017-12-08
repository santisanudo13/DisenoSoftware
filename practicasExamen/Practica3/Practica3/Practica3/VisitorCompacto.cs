using System;
using System.Collections.Generic;
using System.Text;

namespace Practica3
{
    class VisitorCompacto : Visitor
    {
        private int nivel = 0;

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
            return "f " + file.Nombre + "\n";
        }

        public override string visitArchivoComprimido(ArchivoComprimido file)
        {
            return "c " + file.Nombre + "\n";
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
            return str;
        }

        public override string visitEnlaceDirecto(EnlaceDirecto file)
        {
            return "e " + file.Nombre + "\n";
        }
    }
}
