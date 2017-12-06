using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    class PasiegoLebaniego : IPasiego, ILebaniego
    {
        Pasiego pasiego;
        Lebaniego lebaniego;
        TipoContexto contexto;


        public TipoContexto Contexto { get => contexto; set => contexto = value; }
        internal Lebaniego Lebaniego { get => lebaniego; set => lebaniego = value; }
        internal Pasiego Pasiego { get => pasiego; set => pasiego = value; }

        public PasiegoLebaniego(Pasiego pasiego, Lebaniego lebaniego, TipoContexto contexto)
        {
            this.Pasiego = pasiego;
            this.Lebaniego = lebaniego;
            this.Contexto = contexto;
        }


        public string hacerCocido()
        {
            switch (Contexto)
            {
                case TipoContexto.LIEBANA:
                    return Lebaniego.hacerCocido();
                case TipoContexto.PAS:
                    return Pasiego.hacerCocido();

            }
            return null;
        }

        public string hacerOrujo()
        {
            return Lebaniego.hacerOrujo();
        }

        public string hacerQuesada()
        {
            return Pasiego.hacerQuesada();
        }

        public string hacerSobaos()
        {
            return Pasiego.hacerSobaos();
        }
    }
}
