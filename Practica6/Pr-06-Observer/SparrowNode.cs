using CompositeSparrowEnlaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_06_Observer
{
    /// <summary>
    ///     Clase utilizada para visualizar un elemento cualquiera del 
    ///     sistema de archivos Sparrow como nodo de un TreeView. 
    /// </summary>
    public class SparrowNode : TreeNode
    {

        #region Atributos y Propiedades

        /// <summary>
        ///     Elemento del sistema de archivos visualizado por este nodo.
        /// </summary>
        /// <inv>(referencedElement != null)</inv>
        protected ElementoSistemaFicheros referencedElement;

        /// <summary>
        ///     Elemento del sistema de archivos Sparrow referenciado por
        ///     el nodo.
        /// </summary>
        public ElementoSistemaFicheros ReferencedElement
        {
            get
            {
                return referencedElement;
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        ///     Constructor de la clase
        /// </summary>
        /// <param name="sa">
        ///     Elemento del sistema de archivos Sparrow a visualizar
        /// </param>
        /// <pre>(sa != null)</pre>
        public SparrowNode(ElementoSistemaFicheros sa) : base(sa.Nombre)
        {
            sa.RegistrarObserver(new ObserverNode(this));
            this.referencedElement = sa;
            this.Text = referencedElement.Nombre;
        } // SparrowNode

        #endregion

    } // class SparrowNode 
} // namespace
