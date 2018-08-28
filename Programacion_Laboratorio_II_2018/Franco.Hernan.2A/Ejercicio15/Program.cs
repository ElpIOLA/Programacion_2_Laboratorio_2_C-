using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa_Calculadora;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15 Calculadora";
            Console.ForegroundColor = ConsoleColor.Green;

            int opcion = 0;
            double num_1 = 0;
            double num_2 = 0;
            char caracter;

            while(opcion != 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\tIngrese el primer numero: ");
                num_1 = int.Parse(Console.ReadLine());

                Console.Write("\n\tIngrese el segundo numero: ");
                num_2 = int.Parse(Console.ReadLine());

                Console.Write("\n\t\tELIGA LA OPERACION!\n\t[1]SUMA\n\t[2]RESTA\n\t[3]MULTIPLICAR\n\t[4]DIVIDIR\n\t[5]SALIR\n\tRESPUESTA: ");
                opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        caracter = '+';
                        Calculadora.Mostrar(Calculadora.Calcular(num_1, num_2, caracter));
                        break;
                    case 2:
                        caracter = '-';
                        Calculadora.Mostrar(Calculadora.Calcular(num_1, num_2, caracter));
                        break;
                    case 3:
                        caracter = '*';
                        Calculadora.Mostrar(Calculadora.Calcular(num_1, num_2, caracter));
                        break;
                    case 4:
                        caracter = '/';
                        Calculadora.Mostrar(Calculadora.Calcular(num_1, num_2, caracter));
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n\t\t\tLA OPCION ELEGIDA NO ES CORRECTA!\n\n");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
