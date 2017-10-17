using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// ISAAC GUTIERREZ RODRIGUEZ
namespace PatronObserver
{
    /// <summary>
    /// Padre
    /// </summary>
    public class Padre : ObservadorEsposa, ObservadorHijos
    {
        private String nombre;
        private ISet<Hijo> hijos;

        private IList<ObservadorEsposo> observers;

        private Madre esposa;

        /// <summary>
        /// Hijos del matrimonio
        /// </summary>
        public ISet<Hijo> Hijos
        {
            get { return this.hijos; }
            set { }
        }

        /// <summary>
        /// Esposa
        /// </summary>
        public Madre Esposa
        {
            get { return this.esposa; }
            set
            {
                if (this.esposa != null)
                {
                    notifyDivorcio();
                }

                this.esposa = value;

                if (value != null)
                {
                    addObserver(esposa);
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
        /// Constructor de la clase Padre
        /// </summary>
        /// <param name="nombre"> nombre del padre </param>
        public Padre(String nombre)
        {
            this.nombre = nombre;
            this.esposa = null;
            this.hijos = new HashSet<Hijo>();
            observers = new List<ObservadorEsposo>();
        }

        /// <summary>
        /// Metodo que permite anyadir un hijo
        /// </summary>
        /// <param name="hijo"> nuevo hijo </param>
        public void addHijo(Hijo hijo)
        {
            if (esposa != null)
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
        /// <returns> true o false en funcion de si el objeto es el mismo o no </returns>
        public override bool Equals(Object obj)
        {
            Padre padreObj = obj as Padre;
            if (padreObj == null)
            {
                return false;
            }
            else
            {
                return nombre.Equals(padreObj.nombre);
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

        /// <summary>
        /// Recibe la notificacion de un casamiento
        /// </summary>
        /// <param name="esposa"> madre que se ha casado </param>
        public override void casamiento(Madre esposa)
        {
            hijos.Clear();
            notifyDivorcio();
            this.esposa = esposa;
            addObserver(esposa);
        }

        /// <summary>
        /// Recibe la notificacion de un divorcio
        /// </summary>
        public override void divorcio()
        {
            esposa.removeObserver(this);
            this.esposa = null;
            hijos.Clear();
            removeObserver(esposa);
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
        public void addObserver(ObservadorEsposo observador)
        {
            observers.Add(observador);
        }

        /// <summary>
        /// Elimina uno de los observadores de la padre
        /// </summary>
        /// <param name="observador"> observador a eliminar </param>
        public void removeObserver(ObservadorEsposo observador)
        {
            observers.Remove(observador);
        }
    }
}
