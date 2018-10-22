using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 00";

            bool flag = true;
            int numero, maximo = 0, minimo = 0, acumulador = 0;
            float promedio;

            for(int i = 1; i <= 5; i++)
            {
                Console.Write("\n{0}-.Ingrese un numero: ", i);
                numero = int.Parse(Console.ReadLine());
                acumulador += numero;

                if(flag)
                {
                    maximo = numero;
                    minimo = numero;
                    flag = false;
                }
                if(numero > maximo)
                {
                    maximo = numero;
                }
                if(numero < minimo)
                {
                    minimo = numero;
                }
            }
            promedio = (float)acumulador / 5;

            Console.Write("\nMaximo: {0}", maximo);
            Console.Write("\nMinimo: {0}", minimo);
            Console.Write("\nPromedio: {0:#,###.00}\n", promedio);

            Console.ReadLine();
        }
    }
}
