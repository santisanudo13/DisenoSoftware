using Practica4.Strategy;
using System;

namespace Practica4
{
    class Program
    {
        static void Main(string[] args)
        {

            Directorio d = new Directorio("Español áéíóú");

            VisitorExtendido impExt = new VisitorExtendido(new TipografiaCatalana());
            VisitorExtendido impExt2 = new VisitorExtendido(new TipografiaGallega());
            VisitorExtendido impExt3 = new VisitorExtendido(new TipografiaCastellana());
            VisitorExtendido impExt4 = new VisitorExtendido(new TipografiaInternacionalCatalana());
            VisitorExtendido impExt5 = new VisitorExtendido(new TipografiaInternacionalGallega());

            VisitorCompacto impComp = new VisitorCompacto(new TipografiaCatalana());
            VisitorCompacto impComp2 = new VisitorCompacto(new TipografiaGallega());
            VisitorCompacto impComp3 = new VisitorCompacto(new TipografiaCastellana());
            VisitorCompacto impComp4 = new VisitorCompacto(new TipografiaInternacionalCatalana());
            VisitorCompacto impComp5 = new VisitorCompacto(new TipografiaInternacionalGallega());

            Console.Out.WriteLine("-------- Visitor EXTENDIDA --------\n");

            Console.Out.WriteLine("Catalan: " + impExt.visitDirectorio(d));
            Console.Out.WriteLine("Gallego: " + impExt2.visitDirectorio(d));
            Console.Out.WriteLine("Castellano: " + impExt3.visitDirectorio(d));
            Console.Out.WriteLine("Internacional Catalan: " + impExt4.visitDirectorio(d));
            Console.Out.WriteLine("Internacional Gallego: " + impExt5.visitDirectorio(d));

            Console.Out.WriteLine("-------- Visitor Compacto --------\n");

            Console.Out.WriteLine("Catalan: " + impComp.visitDirectorio(d));
            Console.Out.WriteLine("Gallego: " + impComp2.visitDirectorio(d));
            Console.Out.WriteLine("Castellano: " + impComp3.visitDirectorio(d));
            Console.Out.WriteLine("Internacional Catalan: " + impComp4.visitDirectorio(d));
            Console.Out.WriteLine("Internacional Gallego: " + impComp5.visitDirectorio(d));

            Console.ReadLine();
        }
    }
}
