using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";
            int numero = 0;
            bool esNumero = true;


            while (esNumero)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nIngrese un numero del [1 - 100]: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if(numero > 0 && numero < 101)
                    {
                        Console.Write("\nEl numero es valido. Presione Enter...\n");
                        Console.ReadKey();
                        esNumero = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("\nEl numero no es valido. Presione Enter...\n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\nEl numero no es valido. Presione Enter...\n");
                    Console.ReadKey();
                }
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            int contador = 0;


            for(int i = 1; i <= 100; i++)
            {
                if(numero % i == 0)
                {
                    contador++;
                }
            }

            if(contador != 2)
            {
                Console.Write("\nNo es primo. Presione Enter...\n");
            }
            else
            {
                Console.Write("\nEs primo. Presione Enter...\n");
            }
            Console.ReadKey();
        }
    }
}
