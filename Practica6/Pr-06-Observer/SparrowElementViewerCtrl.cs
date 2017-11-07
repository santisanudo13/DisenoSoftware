﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompositeSparrowEnlaces;

namespace Pr_06_Observer
{
    /// <summary>
    ///     Componente gráfico que permite visualizar de manera
    ///     sencilla el nombre y tamaño de un elemento del sistema
    ///     de archivos Sparrow.
    ///     
    ///     El control se compone de una tabla 2x2 que sirve para alinear 
    ///     los elementos del control. Cada celda contiene una etiqueta. 
    ///     Las etiquetas de la izquierda son fijas y muestran los
    ///     nombres de los campos a los que corresponden los valores 
    ///     mostrados por las etiquetas de la derecha.
    /// </summary>
    public partial class SparrowElementViewerCtrl: UserControl
    {
        #region Attributes and Properties

        /// <summary>
        ///     El elemento del sistema de archivos actualmente 
        ///     visualizado.
        /// </summary>
        protected ElementoSistemaFicheros sparrowElement;

        /// <summary>
        ///     El elemento del sistema de archivos actualmente 
        ///     visualizado.
        /// </summary>
        public virtual ElementoSistemaFicheros SparrowElement
        {
            get
            {
                return sparrowElement;
            } // get
            set
            {
                this.sparrowElement = value;
                displayElement();
            } // set
        } // ElementoSistemaFicheros

        #endregion

        #region Constructor

        /// <summary>
        ///     Crea una nueva instancia del componente gráfico.
        /// </summary>
        public SparrowElementViewerCtrl()
        {
            InitializeComponent();
        } // SparrowElementViewerCtrl

        #endregion

        #region Utility Private Methods

        /// <summary>
        ///   Muestra el elemento actualmente referenciado. Si este
        ///   fuese null, muestra unos simples guiones.
        /// </summary>
        /// <pre> (this.lb_NameText != null) && 
        ///       (this.lb_SizeText != null)</pre>
        protected void displayElement()
        {
            if (this.sparrowElement != null) {
               this.lb_NameText.Text = this.sparrowElement.Nombre;
               this.lb_SizeText.Text = this.sparrowElement.calcularTamanyo().ToString();
            } else
            {
                this.lb_NameText.Text = "-";
                this.lb_NameText.Text = "-";
            }
        } // displayElement

        #endregion

        #region Respuestas a eventos

        /// <summary>
        ///     Método que se invoca cuando el control cambia de tamaño
        /// </summary>
        /// <param name="sender">
        ///     Este parámetro se incluye por conformidad con el
        ///     perfil de la operación a implementar, de acuerdo con las
        ///     especificaciones de la plataforma. No se utilizada para
        ///     nada en este caso concreto.
        /// </param>
        /// <param name="e">
        ///     Este parámetro se incluye por conformidad con el
        ///     perfil de la operación a implementar, de acuerdo con las
        ///     especificaciones de la plataforma. No se utilizada para
        ///     nada en este caso concreto.

        /// </param>
        private void SparrowElementViewer_Resize(object sender, EventArgs e)
        {
            // Cuando el tamaño del control cambia, redimensionar la tabla
            // interior para que adquiera las nuevas proporciones del 
            // control
            this.tbl_Layout.Height = this.Height;
            this.tbl_Layout.Width = this.Width;
        } // SparrowElementViewer_Resize

        #endregion
    } // class
}
