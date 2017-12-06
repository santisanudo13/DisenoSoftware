using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixinContexto
{
    /**
     * <sumary>
     * Clase PasiegoLebaniego
     * Superraza formada por la union de las habilidades presentes en pasiegos y lebaniegos
     * </sumary>
     */
    public class PasiegoLebaniego : IPasiego, ILebaniego
    {
        //contexto: indica si el pasiegolebaniego se encuentra en la region de Liebana o en la region de la Vega de Pas
        TipoContexto contexto;
        IPasiego pasiegoMixed = new Pasiego();
        ILebaniego lebaniegoMixed = new Lebaniego();

        /**
         * <summary> Propiedad Contexto </summary>
         */
        public TipoContexto Contexto
        {
            get { return contexto; }
            set { contexto = value; }
        }

        /**
         * <summary> Cosntructor de la clase PasiegoLebaniego </summary>
         * <param name="contexto"> El parametro toma un objeto de la clase TipoContexto </param>
         */
        public PasiegoLebaniego(TipoContexto contexto)
        {
            this.contexto = contexto;
        }

        /**
         * <summary> Metodo para hacer un cocido. En funcion del contexto (si el PasiegLebaniego se encuentra en la region de Liebana
         * o en la region de la Vega de Pas) el cocido sera lebaniego o montanes </summary>
         * <returns> String indicando el tipo de cocido que se esta haciendo </returns>
         */
        public string hacerCocido()
        {
            if (contexto == TipoContexto.LIEBANA)
            {
                return lebaniegoMixed.hacerCocido();
            }
            else
            {
                return pasiegoMixed.hacerCocido();
            }
        }

        /**
         * <summary> Metodo para hacer orujo </summary>
         * <returns> String indicando que el orujo se esta haciendo </returns>
         */
        public string hacerOrujo()
        {
            return lebaniegoMixed.hacerOrujo();
        }

        /**
         * <summary> Metodo para hacer quesada </summary>
         * <returns> String indicando que la quesada se esta haciendo </returns>
         */
        public string hacerQuesada()
        {
            return pasiegoMixed.hacerQuesada();
        }

        /**
         * <summary> Metodo para hacer sobaos </summary>
         * <returns> String indicando que los sobaos se estan haciendo </returns>
         */
        public string hacerSobaos()
        {
            return pasiegoMixed.hacerSobaos();
        }
    }
}
