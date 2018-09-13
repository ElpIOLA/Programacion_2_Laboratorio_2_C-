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
            int opcion = 0;
            bool value = true;
            Calculadora suma = new Calculadora();

            while (opcion != 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("\n1 - Convertir de Binario a Entero");
                Console.Write("\n2 - Convertir de Entero a Binario");
                Console.Write("\n3 - Mostrar el total en Binario");
                Console.Write("\n4 - Mostrar el total en Entero");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n5 - Salir");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("\nIngrese opcion: ");
                value = int.TryParse(Console.ReadLine(), out opcion);
                while(value == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nError! Reingrese una opcion que sea valida: ");
                    value = int.TryParse(Console.ReadLine(), out opcion);
                }
                switch (opcion)
                {
                    case 1:
                        double numero_1;
                        string binario_1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nIngrese un numero Binario: ");
                        binario_1 = Console.ReadLine();
                        numero_1 = Conversor.BinarioDecimal(binario_1);
                        suma.Acumulador(binario_1);
                        Console.Write("\nNumero convertido {0} --- {1}\n", binario_1, numero_1);
                        break;
                    case 2:
                        int numero_2;
                        string binario_2;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nIngrese un numero Entero: ");
                        numero_2 = int.Parse(Console.ReadLine());
                        binario_2 = Conversor.DecimalBinario(numero_2);
                        Console.Write("\nNumero convertido {0} --- {1}\n", numero_2,binario_2);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nEl valor total en Binario es: ");
                        Console.WriteLine(suma.getResultadoBinario());
                        Console.Write("\n");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nEl valor total en Entero es: ");
                        Console.WriteLine(suma.getResultadoEntero());
                        Console.Write("\n");
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n\t\tFIN DEL PROGRAMA\n");
                        opcion = 5;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\tLA OPCION INGRESADA NO ES CORRECTA\n");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
