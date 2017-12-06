using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// ISAAC GUTIERREZ RODRIGUEZ
namespace PatronObserver
{
    /// <summary>
    /// Madre
    /// </summary>
    public class Madre : ObservadorEsposo, ObservadorHijos
    {
        private String nombre;

        private IList<ObservadorEsposa> observers;

        private ISet<Hijo> hijos;
        private Padre esposo;

        /// <summary>
        /// Hijos del matrimonio
        /// </summary>
        public ISet<Hijo> Hijos
        {
            get { return this.hijos; }
            set { }
        }

        /// <summary>
        /// Esposo
        /// </summary>
        public Padre Esposo
        {
            get { return this.esposo; }
            set
            {
                if (this.esposo != null)
                {
                    notifyDivorcio();
                }

                this.esposo = value;

                if (value != null)
                {
                    addObserver(esposo);
                    notifyCasamiento();
                }
            }
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
        /// Constructor de la clase Madre
        /// </summary>
        /// <param name="nombre"> nombre de la madre </param>
        public Madre(String nombre)
        {
            this.nombre = nombre;
            this.esposo = null;
            this.hijos = new HashSet<Hijo>();
            observers = new List<ObservadorEsposa>();
        }

        /// <summary>
        /// Metodo que permite anyadir un hijo
        /// </summary>
        /// <param name="hijo"> nuevo hijo </param>
        public void addHijo(Hijo hijo)
        {
            if (esposo != null)
            {
                hijos.Add(hijo);
                notifyHijo(hijo);
            }
        }

        /// <summary>
        /// Notifica un nuevo casamiento
        /// </summary>
        public void notifyCasamiento()
        {
            for (int i = observers.Count - 1; i >= 0; i--)
            {
                observers[i].casamiento(this);
            }
        }

        /// <summary>
        /// Notifica el divorcio
        /// </summary>
        public void notifyDivorcio()
        {
            for (int i = observers.Count - 1; i >= 0; i--)
            {
                observers[i].divorcio();
            }
        }

        /// <summary>
        /// Notifica el nacimiento de un nuevo hijo
        /// </summary>
        /// <param name="hijo"> hijo </param>
        public void notifyHijo(Hijo hijo)
        {
            for (int i = observers.Count - 1; i >= 0; i--)
            {
                observers[i].nuevoHijo(hijo);
            }
        }

        /// <summary>
        /// Metodo que permite determinar si dos objetos son iguales
        /// </summary>
        /// <param name="obj"> objeto a comparar con el actual </param>
        /// <returns> true o false en funcion de si el objeto es el mismo ono </returns>
        public override bool Equals(Object obj)
        {
            Madre madreObj = obj as Madre;
            if (madreObj == null)
            {
                return false;
            }
            else
            {
                return nombre.Equals(madreObj.nombre);
            }
        }

        /// <summary>
        /// Retorna el hashcode de la madre
        /// </summary>
        /// <returns> hashcode de la madre</returns>
        public override int GetHashCode()
        {
            return nombre.GetHashCode();
        }

        /// <summary>
        /// Recibe la notificacion de un casamiento
        /// </summary>
        /// <param name="esposo"> padre que se ha casado </param>
        public override void casamiento(Padre esposo)
        {
            hijos.Clear();
            notifyDivorcio();
            this.esposo = esposo;
            addObserver(esposo);
        }

        /// <summary>
        /// Recibe la notificacion un divorcio
        /// </summary>
        public override void divorcio()
        {
            esposo.removeObserver(this);
            this.esposo = null;
            hijos.Clear();
            removeObserver(esposo);
        }

        /// <summary>
        /// Recibe la notificacion de un nuevo hijo para la pareja
        /// </summary>
        /// <param name="hijo"> nuevo hijo </param>
        public override void nuevoHijo(Hijo hijo)
        {
            hijos.Add(hijo);
        }

        /// <summary>
        /// Anyade un nuevo observador de la madre
        /// </summary>
        /// <param name="observador"> observador a anyadir </param>
        public void addObserver(ObservadorEsposa observador)
        {
            observers.Add(observador);
        }

        /// <summary>
        /// Elimina uno de los observadores de la madre
        /// </summary>
        /// <param name="observador"> observador a eliminar </param>
        public void removeObserver(ObservadorEsposa observador)
        {
            observers.Remove(observador);
        }
    }
}
