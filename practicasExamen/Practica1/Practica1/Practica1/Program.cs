using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego(new Pasiego(), new Lebaniego(), TipoContexto.LIEBANA);


            Console.WriteLine(pasiegoLebaniego.hacerOrujo());
            Console.WriteLine(pasiegoLebaniego.hacerQuesada());
            Console.WriteLine(pasiegoLebaniego.hacerSobaos());

            pasiegoLebaniego.Contexto = TipoContexto.LIEBANA;
            Console.WriteLine(pasiegoLebaniego.hacerCocido());

            pasiegoLebaniego.Contexto = TipoContexto.PAS;
            Console.WriteLine(pasiegoLebaniego.hacerCocido());

            Console.ReadLine();
        }
    }
}
