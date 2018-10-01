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
            Console.Title = "Ejercicio Nro 04";

            int divisor = 0, acumulador = 0, porciento = 0;

            for(int i = 2; i <= 1000; i ++)
            {
                divisor = i / 2;

                for(int j = 1; j <= divisor; j ++)
                {
                    porciento = i % j;
                    if (porciento == 0)
                        acumulador += j;
                }

                if(acumulador == i)
                    Console.Write("\nEl numero: {0} ", i + "es perfecto");
            }

            Console.ReadKey();
        }
    }
}
