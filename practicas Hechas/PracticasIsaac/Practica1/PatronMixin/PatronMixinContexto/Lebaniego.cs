using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixinContexto
{
    /**
     * <summary> 
     * Lebaniego 
     * </summary>
     */
    public class Lebaniego : ILebaniego
    {
        /**
         * <summary> Metodo para hacer un cocido lebaniego </summary>
         * <returns> String indicando que el cocido se esta haciendo </returns>
         */
        public virtual String hacerCocido()
        {
            return "Haciendo Cocido Lebaniego";
        }

        /**
         * <summary> Metodo para hacer orujo </summary>
         * <returns> String indicando que el orujo se esta haciendo </returns>
         */
        public virtual String hacerOrujo()
        {
            return "Haciendo Orujo";
        }
    }
}
