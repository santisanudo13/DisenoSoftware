using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixinContexto
{
    /**
     * <summary> 
     * Clase Pasiego 
     * </summary>
     */
    public class Pasiego : IPasiego
    {
        /**
         * <summary> Metodo para hacer sobaos </summary>
         * <returns> String indicando que los sobaos se estan haciendo </returns>
         */
        public virtual String hacerSobaos()
        {
            return "Haciendo Sobaos";
        }

        /**
         * <summary> Metodo para hacer quesada </summary>
         * <returns> String indicando que la quesada se esta haciendo </returns>
         */
        public virtual String hacerQuesada()
        {
            return "Haciendo Quesada";
        }

        /**
         * <summary> Metodo para hacer un cocido montanes </summary>
         * <returns> String indicando que el cocido se esta haciendo </returns>
         */
        public virtual String hacerCocido()
        {
            return "Haciendo Cocido Montanes";
        }
    }
}
