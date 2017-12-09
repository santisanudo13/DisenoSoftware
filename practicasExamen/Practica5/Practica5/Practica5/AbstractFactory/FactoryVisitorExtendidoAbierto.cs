using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class FactoryVisitorExtendidoAbierto : Factory
    {
        //instancia de la factoria
        private static FactoryVisitorExtendidoAbierto instancia;
        private static Tipografia tipografia;


        protected FactoryVisitorExtendidoAbierto() { }

        public static FactoryVisitorExtendidoAbierto getInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoryVisitorExtendidoAbierto();
            }
            return instancia;
        }


        public static void setVisualizacion(Tipografia tipo)
        {
            tipografia = tipo;
        }

        public override Tipografia crearTipografia()
        {
            return (Tipografia)tipografia.clone();
        }

        public override Visitor crearVisitor(Tipografia tipografia)
        {
            return new VisitorExtendido(tipografia);
        }
    }
}