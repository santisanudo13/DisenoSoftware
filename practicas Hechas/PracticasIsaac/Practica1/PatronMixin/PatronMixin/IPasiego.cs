using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixin
{
    /**
     * <summary>
     * Interfaz IPasiego
     * Contiene los metodos necesarios para preparar las comidas caracteristicas de un Pasiego
     * </summary>
     */
    public interface IPasiego
    {
        /**
         * <summary> Metodo para hacer sobaos </summary>
         * <returns> String indicando que los sobaos se estan haciendo </returns>
         */
        String hacerSobaos();

        /**
         * <summary> Metodo para hacer quesada </summary>
         * <returns> String indicando que la quesada se esta haciendo </returns>
         */
        String hacerQuesada();
    }
}
