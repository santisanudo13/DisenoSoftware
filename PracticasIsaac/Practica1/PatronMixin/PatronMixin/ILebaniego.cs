using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixin
{
    /**
     * <summary> 
     * Interfaz ILebaniego
     * Contiene los metodos necesarios para preparar las comidas caracteristicas de un Lebaniego
     * </summary>
     */
    public interface ILebaniego
    {
        /**
         * <summary> Metodo para hacer un cocido </summary>
         * <returns> String indicando que el cocido se esta haciendo </returns>
         */
        String hacerCocido();

        /**
         * <summary> Metodo para hacer orujo </summary>
         * <returns> String indicando que el orujo se esta haciendo </returns>
         */
        String hacerOrujo();
    }
}
