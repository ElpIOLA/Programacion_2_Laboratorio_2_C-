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
            Console.Title = "Ejercicio 01";
            bool iguales = true;
            int mayor = 0,
                menor = 0,
                numero = 0,
                acumulador = 0;
            float promedio = 0;
            bool primo;

            for(int i = 0; i < 5; i++)
            {
                Console.Write("\nIngrese un numero: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error. Ingrese un valor entero y numérico.");
                }
                acumulador += numero;
                if (iguales)
                {
                    mayor = numero;
                    menor = numero;
                    iguales = false;
                }
                if(mayor < numero)
                {
                    mayor = numero;
                }
                if(menor > numero)
                {
                    menor = numero;
                }
            }

            for(int j = 2; j <= mayor; j++)
            {
                primo = true;
                for (int divisor = 2; divisor < 1; divisor++)
                {
                    if((j % divisor) == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo)
                    Console.WriteLine("El número {0} es un número primo menor a {1}", j, mayor);
                break;
            }


            promedio = (float)acumulador / 5;
            Console.Write("\n\tPromedio: {0}", promedio);
            Console.Write("\n\tMaximo: {0}", mayor);
            Console.Write("\n\tMinimo: {0}", menor);
            Console.ReadLine();
        }
    }
}
