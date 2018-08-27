using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09 Imprimir Piramide";
            Console.ForegroundColor = ConsoleColor.Green;

            int altura;

            Console.Write("\n\tIngrese el tamaño de la piramide: ");
            altura = int.Parse(Console.ReadLine());

            for(int i = 1; i <= altura; i++)
            {
                for(int j = 0; j < altura - i; j++)
                {
                    Console.Write(" ");
                }
                for(int a = 0; a < (i * 2) - 1; a ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
