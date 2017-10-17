using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Isaac Gutierrez Rodriguez
namespace CompositeSparrow
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
    }
}
