using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class FactoryInternacionalCatalana : Factory
    {
        //instancia de la factoria
        private static FactoryInternacionalCatalana instancia;

        protected FactoryInternacionalCatalana() { }

        public static FactoryInternacionalCatalana getInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoryInternacionalCatalana();
            }
            return instancia;
        }

        public override Tipografia crearTipografia()
        {
            return new TipografiaInternacionalCatalana();
        }

        public override Visitor crearVisitor(Tipografia tipografia)
        {
            return new VisitorExtendido(tipografia);
        }
    }
}