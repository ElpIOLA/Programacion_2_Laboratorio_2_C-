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
            Console.Title = "Ejercicio01";
            Console.ForegroundColor = ConsoleColor.Cyan;

            int i;
            int numero = 0;
            int acum = 0;
            int maximo = 0;
            int minimo = 0;
            float promedio = 0;
            bool flag = true;

            for(i=0;i<5;i++)
            {
                Console.Write("{0}-.Ingrese un numero: ", i);
                numero = int.Parse(Console.ReadLine());
                acum += numero;

                if (flag)
                {
                    maximo = minimo = numero;
                    flag = false;
                }

                if (numero > maximo)
                {
                    maximo = numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                }
                
            }

            promedio = acum / (float)i;
            Console.WriteLine("\nEl promedio es: {0:0.00}", promedio);
            Console.WriteLine("El numero Maximo es: {0}", maximo);
            Console.WriteLine("El numero Minimo es: {0}", minimo);
            Console.ReadLine();
        }
    }
}
