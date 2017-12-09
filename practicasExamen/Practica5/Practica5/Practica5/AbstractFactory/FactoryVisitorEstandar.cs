using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class FactoryVisitorEstandar : Factory
    {

        //instancia de la factoria
        private static FactoryVisitorEstandar instancia;

        protected FactoryVisitorEstandar() { }

        public static FactoryVisitorEstandar getInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoryVisitorEstandar();
            }
            return instancia;
        }

        public override Tipografia crearTipografia()
        {
            return new TipografiaCastellana();
        }

        public override Visitor crearVisitor(Tipografia tipografia)
        {
            return new VisitorExtendido(tipografia);
        }
    }
}