using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// ISAAC GUTIERREZ RODRIGUEZ
namespace PatronObserver
{
    /// <summary>
    /// Hijo
    /// </summary>
    public class Hijo
    {
        private String nombre;

        /// <summary>
        /// Constructor de la clase Hijo
        /// </summary>
        /// <param name="nombre"> nombre del hijo </param>
        public Hijo(String nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Metodo que permite determinar si dos objetos son iguales
        /// </summary>
        /// <param name="obj"> objeto a comparar con el actual </param>
        /// <returns> true o false en funcion de si el objeto es el mismo o no </returns>
        public override bool Equals(Object obj)
        {
            Hijo hijoObj = obj as Hijo;
            if (hijoObj == null)
            {
                return false;
            }
            else
            {
                return nombre.Equals(hijoObj.nombre);
            }
        }

        /// <summary>
        /// Retorna el hashcode del objeto
        /// </summary>
        /// <returns> hashcode del objeto </returns>
        public override int GetHashCode()
        {
            return nombre.GetHashCode();
        }
    }
}
