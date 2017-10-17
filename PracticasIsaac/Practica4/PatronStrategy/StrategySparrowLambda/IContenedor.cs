using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySparrowLambda
{
    /// <summary>
    /// Interfaz IContenedor. Refleja el comportamiento de elementos que pueden contener otros.
    /// </summary>
    interface IContenedor
    {
        /// <summary>
        /// Metodo que permite anyadir un elemento al contenedor
        /// </summary>
        /// <param name="e"> elemento a anyadir </param>
        void anadeElemento(ElementoSistemaFicheros e);

        /// <summary>
        /// Metodo que permite eliminar un elemento del contenedor
        /// </summary>
        /// <param name="e"> elemento a eliminar </param>
        void eliminaElemento(ElementoSistemaFicheros e);

        /// <summary>
        /// Metodo que permite obtener los elementos contenidos por el directorio
        /// </summary>
        /// <returns> lista con los elementos contenidos por el directorio </returns>
        List<ElementoSistemaFicheros> obtenerElementos();
    }
}
