﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ISAAC GUTIERREZ RODRIGUEZ
namespace StrategySparrow
{
    /// <summary>
    /// Interfaz IEnlazable. Refleja el comportamiento de aquellos elementos que pueden ser enlazados
    /// </summary>
    public interface IEnlazable
    {
        /// <summary>
        /// Propiedad Nombre. Define el metodo que permite obtener el nombre del elemento enlazado
        /// </summary>
        String Nombre { get; }
    }
}
