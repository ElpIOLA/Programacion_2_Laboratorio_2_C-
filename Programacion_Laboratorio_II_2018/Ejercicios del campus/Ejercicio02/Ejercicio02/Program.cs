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
            Console.Title = "Ejercicio 02";
            int numero = 0;
            bool value;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("1 - Convertir de Binario a Entero");
            Console.WriteLine("2 - Convertir de Entero a Binario");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("3 - Salir");
            value = int.TryParse(Console.ReadLine(), out numero);
            while(value == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError! Reingrese un numero: ");
                value = int.TryParse(Console.ReadLine(), out numero);
            }
            switch (numero)
            {
                case 1:
                    string bin;
                    double n;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nIngrese numero binario: ");
                    bin = Console.ReadLine();
                    n = Conversor.BinarioDecimal(bin);
                    Console.WriteLine("\n-Numero Entero: {0}\n", n);
                    break;
                case 2:
                    string bina;
                    double nu;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nIngrese numero decimal: ");
                    nu = double.Parse(Console.ReadLine());
                    bina = Conversor.DecimalBinario(nu);
                    Console.WriteLine("\n-Numero Binario: {0}\n", bina);
                    break;
                case 3:

                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nLa opcion no es correcta!\n");
                    break;
            }


            Console.ReadLine();
        }
    }
}
