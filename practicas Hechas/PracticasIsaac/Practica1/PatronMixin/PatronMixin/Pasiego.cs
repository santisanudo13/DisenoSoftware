using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMixin
{
    /**
     * <summary>
     * Clase Pasiego
     * Contiene los metodos necesarios para preparar las comidas caracteristicas de un Pasiego
     * </summary>
     */
    public class Pasiego : IPasiego
    {

        /**
         * <summary> Metodo para hacer sobaos </summary>
         * <returns> String indicando que los sobaos se estan haciendo </returns>
         */
        public String hacerSobaos()
        {
            return "Haciendo Sobaos";
        }

        /**
         * <summary> Metodo para hacer quesada </summary>
         * <returns> String indicando que la quesada se esta haciendo </returns>
         */
        public String hacerQuesada()
        {
            return "Haciendo Quesada";
        }
    }
}
