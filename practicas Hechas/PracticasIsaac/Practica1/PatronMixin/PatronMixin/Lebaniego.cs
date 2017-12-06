using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixin
{
    /**
     * <summary> 
     * Clase Lebaniego
     * Contiene los metodos necesarios para preparar las comidas caracteristicas de un Lebaniego
     * </summary>
     */
    public class Lebaniego : ILebaniego
    {
        /**
         * <summary> Metodo para hacer un cocido </summary>
         * <returns> String indicando que el cocido se esta haciendo </returns>
         */
        public String hacerCocido()
        {
            return "Haciendo Cocido";
        }

        /**
         * <summary> Metodo para hacer orujo </summary>
         * <returns> String indicando que el orujo se esta haciendo </returns>
         */
        public String hacerOrujo()
        {
            return "Haciendo Orujo";
        }
    }
}
