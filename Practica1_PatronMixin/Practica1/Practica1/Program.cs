using System;

namespace Practica1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PasiegoLebaniego pasLeb = new PasiegoLebaniego(TipoContexto.PAS, new Pasiego(), new Lebaniego());

            salidaConsolaDatos(pasLeb);
            pasLeb.Contexto = TipoContexto.LIEBANA;
			salidaConsolaDatos(pasLeb);

            Console.ReadLine();
		}

        public static void salidaConsolaDatos(PasiegoLebaniego pasLeb)
        {
			Console.WriteLine("Contexto: " + pasLeb.Contexto);
			Console.WriteLine(pasLeb.hacerCocido());
			Console.WriteLine(pasLeb.hacerSobaos());
			Console.WriteLine(pasLeb.hacerOrujo());
            Console.WriteLine(pasLeb.hacerQuesada());
        }
    }
}
