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
            int numero = 0;
            int i = 0;
            double potencia;
            bool flag = true;

            while (flag == true)
            {
                Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    potencia = Math.Pow(numero, 2);
                    Console.WriteLine("La potencia al cuadrado es: {0}", potencia);
                    potencia = Math.Pow(numero, 3);
                    Console.WriteLine("La potencia al cubo es: {0}", potencia);
                    flag = false;
                }
                else
                {
                    Console.Write("Error! Reingrese el numero por favor\n");
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
