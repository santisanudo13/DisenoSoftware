using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    abstract class Factory
    {
        public abstract Tipografia crearTipografia();

        public abstract Visitor crearVisitor(Tipografia tipografia);

    }
}
