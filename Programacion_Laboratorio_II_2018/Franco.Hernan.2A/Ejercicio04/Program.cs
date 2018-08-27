using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04 Numero Perfecto";
            Console.ForegroundColor = ConsoleColor.Green;
            int dividir = 0;
            int divisores = 0;
            int resultado;
            for (int i = 0; i < 10000; i++)
            {
                resultado = 0;
                dividir = i / 2;

                for (int j = 1; j <= dividir; j++)
                {
                    divisores = i % j;
                    if(divisores == 0)
                    {
                        resultado = resultado + j;
                    }
                }

                if(resultado == i)
                {
                    Console.WriteLine("\nEl numero {0}", i, " es perfecto");
                }
            }
            Console.ReadLine();
        }
    }
}
