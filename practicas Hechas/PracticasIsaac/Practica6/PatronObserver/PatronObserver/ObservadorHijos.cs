using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// ISAAC GUTIERREZ RODRIGUEZ
namespace PatronObserver
{
    /// <summary>
    /// Interfaz que define los metodos para observar los hijos
    /// </summary>
    public interface ObservadorHijos
    {
        /// <summary>
        /// Recibe la notificacion de un nuevo hijo
        /// </summary>
        /// <param name="hijo"> nuevo hijo </param>
        void nuevoHijo(Hijo hijo);
    }
}
