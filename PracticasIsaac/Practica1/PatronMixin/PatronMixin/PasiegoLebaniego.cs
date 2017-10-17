using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixin
{
    /**
     * <sumary>
     * Clase PasiegoLebaniego
     * Superraza formada por la union de las habilidades presentes en pasiegos y lebaniegos
     * </sumary>
     */
    public class PasiegoLebaniego : IPasiego, ILebaniego 
    {
        IPasiego pasiegoMixed = new Pasiego();
        ILebaniego lebaniegoMixed = new Lebaniego();

        /**
         * <summary> Metodo para hacer un cocido </summary>
         * <returns> String indicando el tipo de cocido que se esta haciendo </returns>
         */
        public virtual String hacerCocido() {
            return lebaniegoMixed.hacerCocido();
        }

        /**
         * <summary> Metodo para hacer orujo </summary>
         * <returns> String indicando que el orujo se esta haciendo </returns>
         */
        public virtual String hacerOrujo() {
            return lebaniegoMixed.hacerOrujo();
        }

        /**
        * <summary> Metodo para hacer sobaos </summary>
        * <returns> String indicando que los sobaos se estan haciendo </returns>
        */
        public virtual String hacerSobaos()
        {
            return pasiegoMixed.hacerSobaos();
        }

        /**
         * <summary> Metodo para hacer quesada </summary>
         * <returns> String indicando que la quesada se esta haciendo </returns>
         */
        public virtual String hacerQuesada()
        {
            return pasiegoMixed.hacerQuesada();
        }

    }
}
