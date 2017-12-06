using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// ISAAC GUTIERREZ RODRIGUEZ
namespace PatronObserver
{
    /// <summary>
    /// Clase abstracta que permite observar esposas
    /// </summary>
    public abstract class ObservadorEsposa : ObservadorHijos
    {
        /// <summary>
        /// Recibe la notificacion de un casamiento
        /// </summary>
        /// <param name="esposa"> madre que se ha casado </param>
        public abstract void casamiento(Madre esposa);

        /// <summary>
        /// Recibe la notificacion de un divorcio
        /// </summary>
        public abstract void divorcio();

        /// <summary>
        /// Recibe la notificacion de un nuevo hijo para la pareja
        /// </summary>
        /// <param name="hijo"> nuevo hijo </param>
        public abstract void nuevoHijo(Hijo hijo);
    }
}