using System;

namespace AbstractFactorySparrowInjection.SistemaFicheros
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
