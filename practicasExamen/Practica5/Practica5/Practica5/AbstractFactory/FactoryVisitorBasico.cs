using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class FactoryVisitorBasico : Factory
    {

        //instancia de la factoria
        private static FactoryVisitorBasico instancia;

        protected FactoryVisitorBasico() { }

        public static FactoryVisitorBasico getInstance()
        {
            // si la instancia no existe, la creamos
            if (instancia == null)
            {
                instancia = new FactoryVisitorBasico();
            }
            return instancia;
        }

        public override Tipografia crearTipografia()
        {
            return new TipografiaInternacionalGallega();
        }

        public override Visitor crearVisitor(Tipografia tipografia)
        {
            return new VisitorCompacto(tipografia);
        }
    }
}
