using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_11;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0,
                maximo = 0,
                minimo = 0,
                acumulador = 0;
            bool flag = true,
                esValido = false;
            float promedio = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                esValido = Validacion.Validar(numero, -100, 100);

                while(esValido == false)
                {
                    Console.Write("Reingrese el numero: ");
                    numero = int.Parse(Console.ReadLine());
                    esValido = Validacion.Validar(numero, -100, 100);
                }

                if (esValido == true)
                {
                    
                    acumulador += numero;

                    if (flag)
                    {
                        maximo = numero;
                        minimo = numero;
                        flag = false;
                    }

                    if (maximo < numero)
                    {
                        maximo = numero;
                    }
                    if (minimo > numero)
                    {
                        minimo = numero;
                    }
                }
            }

            Console.WriteLine("Maximo: {0}", maximo);
            Console.WriteLine("Minimo: {0}", minimo);
            Console.WriteLine("Promedio: {0:0.00}", promedio = (float)acumulador / 5);

            Console.ReadKey();
        }
    }
}
