﻿using System;

//ISAAC GUTIERREZ RODRIGUEZ
namespace AbstractFactorySparrow.Estrategias
{
    /// <summary>
    /// Visualizacion: Estrategia Catalana
    /// </summary>
    public class VisualizacionCatalana : Visualizacion
    {

        private const String stringReemplazo = "ny";

        /// <summary>
        /// Metodo que retorna la visualizacion del sistema de ficheros para la estrategia catalana
        /// </summary>
        /// <param name="str"> string conteniendo el sistema de ficheros a utilizar </param>
        /// <returns> visualizacion del sistema de ficheros para la estrategia catalana </returns>
        public override String visualizacion(String str)
        {
            str = str.Replace("ñ", stringReemplazo);
            return str.Replace("Ñ", "ny");
        }
    }
}
