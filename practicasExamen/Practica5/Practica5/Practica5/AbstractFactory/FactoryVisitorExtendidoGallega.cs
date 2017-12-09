using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class FactoryVisitorExtendidoGallega : Factory
    {
        //instancia de la factoria
        private static FactoryVisitorExtendidoGallega instancia;

        protected FactoryVisitorExtendidoGallega() { }

        public static FactoryVisitorExtendidoGallega getInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoryVisitorExtendidoGallega();
            }
            return instancia;
        }

        public override Tipografia crearTipografia()
        {
            return new TipografiaInternacionalGallega();
        }

        public override Visitor crearVisitor(Tipografia tipografia)
        {
            return new VisitorExtendido(tipografia);
        }
    }
}