using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// ISAAC GUTIERREZ RODRIGUEZ
namespace PatronObserver
{
    /// <summary>
    /// Clase abstracta que permite observar esposos
    /// </summary>
    public abstract class ObservadorEsposo : ObservadorHijos
    {
        /// <summary>
        /// Recibe la notificacion de un casamiento
        /// </summary>
        /// <param name="esposo"> padre que se ha casado </param>
        public abstract void casamiento(Padre esposo);

        /// <summary>
        /// Recibe la notificacion un divorcio
        /// </summary>
        public abstract void divorcio();

        /// <summary>
        /// Recibe la notificacion de un nuevo hijo para la pareja
        /// </summary>
        /// <param name="hijo"> nuevo hijo </param>
        public abstract void nuevoHijo(Hijo hijo);
    }
}
