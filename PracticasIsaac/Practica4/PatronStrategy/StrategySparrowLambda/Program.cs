using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySparrowLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] castellano = { "ñ","á","é","í","ó","ú" };
            String[] catalan = { "ny", "á", "é", "í", "ó", "ú" };
            String[] gallego = { "nh", "á", "é", "í", "ó", "ú" };
            String[] internacionalGallego = { "nh", "a", "e", "i", "o", "u" };
            String[] internacionalCatalan = { "ny", "a", "e", "i", "o", "u" };


            Directorio directorio = new Directorio("Español áéíóú");

            ImpresoraExtendida impExt = new ImpresoraExtendida();

            String resultadoCastellano = impExt.imprimirDirectorio(directorio, (str) => {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], castellano[i]);
                }
                return str;
            });

            String resultadoInternacionalCatalan = impExt.imprimirDirectorio(directorio, (str) => {
                for (int i = 0; i < castellano.Length; i++)
                {
                   str = str.Replace(castellano[i], internacionalCatalan[i]);
                }
                return str;
            });

            String resultadoInternacionalGallego = impExt.imprimirDirectorio(directorio, (str) => {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], internacionalGallego[i]);
                }
                return str;
            });

            
            String resultadoCatalan = impExt.imprimirDirectorio(directorio, (str) => {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], catalan[i]);
                }
                return str;
            });

            String resultadoGallego = impExt.imprimirDirectorio(directorio, (str) => {
                for (int i = 0; i < castellano.Length; i++)
                {
                    str = str.Replace(castellano[i], gallego[i]);
                }
                return str;
            });

            Console.Out.WriteLine("Castellano: " + resultadoCastellano);
            Console.Out.WriteLine("Catalan: " + resultadoCatalan);
            Console.Out.WriteLine("Gallego: " + resultadoGallego);
            Console.Out.WriteLine("Internacional Catalan: "+resultadoInternacionalCatalan);
            Console.Out.WriteLine("Internacional Gallego: " + resultadoInternacionalGallego);


            Console.ReadLine();

        }
    }
}
