using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio20;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(15,(float)15.55);
            Euro euro = new Euro(10, (float)1.3642);

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDolar: ${0}",dolar.GetCotizacion());

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nEuro: ${0}",euro.GetCotizacion());

            if(dolar == euro)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("\nValen igual respecto al dolar!\n");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("\nNo valen igual respecto al dolar!\n");
            }
            Console.ReadLine();
        }
    }
}
