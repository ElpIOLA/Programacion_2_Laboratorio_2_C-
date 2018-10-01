using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int numero = 0, cuadrado = 0, cubo = 0, cont = 0;
            bool flag = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nIngrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (flag)
            { 
                if (numero <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nError! Reingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                }
                else
                {
                    flag = false;
                }
                cont++;
            }

            cuadrado = numero * numero;
            cubo = (numero * numero) * numero;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nNumero: {0}", numero);
            Console.WriteLine("\nCuadrado: {0}", cuadrado);
            Console.WriteLine("\nCubo: {0}", cubo);

            Console.ReadKey();
        }
    }
}
