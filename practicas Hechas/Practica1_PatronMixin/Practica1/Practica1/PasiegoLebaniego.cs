using System;
namespace Practica1
{
    public class PasiegoLebaniego : ILebaniego, IPasiego
    {
        private TipoContexto contexto;
        public TipoContexto Contexto
        {
            get
            {
                return contexto;
            }
            set
            {
                this.contexto = value;
            }
        }

        //MIXINS DEBEN SER PRIVADOS
        private Pasiego pasiegoMixin;
        private Lebaniego lebaniegoMixin;

        public PasiegoLebaniego(TipoContexto contexto, Pasiego pasiegoMixin, Lebaniego lebaniegoMixin)
        {
            Contexto = contexto;
            this.pasiegoMixin = pasiegoMixin;
            this.lebaniegoMixin = lebaniegoMixin;
        }

        public string hacerCocido()
        {
            String str = "";
            if (Contexto.Equals(TipoContexto.LIEBANA))
            {
                str = lebaniegoMixin.hacerCocido();
            }
            if (Contexto.Equals(TipoContexto.PAS))
            {
                str = pasiegoMixin.hacerCocido();
            }
            return str;
        }

        public string hacerQuesada()
        {
            return pasiegoMixin.hacerQuesada();
        }

        public string hacerSobaos()
        {
            return pasiegoMixin.hacerSobaos();
        }


        public string hacerOrujo()
        {
            return lebaniegoMixin.hacerOrujo();
        }

    }
}
