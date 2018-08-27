using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int numero;
            int i;
            bool esPrimo = true;

            Console.Write("Ingrese numero: ");
            numero = int.Parse(Console.ReadLine());

            for (i = 2; i < numero; i++)
            {
                if(numero % i == 0)
                {
                    esPrimo = false;
                    i = numero;
                }
            }
            if(esPrimo)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
            Console.ReadLine();
        }
    }
}
