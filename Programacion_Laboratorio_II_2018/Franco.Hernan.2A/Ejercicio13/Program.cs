using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa_Conversor;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13 Conversor";
            Console.ForegroundColor = ConsoleColor.Green;
            double numeroDecimal;
            int opcion;
            string numeroBinario;

            Console.Write("\n\t¿Que desea convertir? \n\t Decimal a Binario = [1]\n\t Binario a Decimal = [2]\n\tRespuesta: ");
            opcion = int.Parse(Console.ReadLine());

            if(opcion == 1)
            {
                Console.WriteLine("\n\t\t\tDECIMAL A BINARIO\n");
                Console.Write("Ingrese un numero Decimal: ");
                numeroDecimal = double.Parse(Console.ReadLine());
                numeroBinario = Conversor.DecimalBinario(numeroDecimal);
                Console.WriteLine("El numero {0} se convirtio en binario: {1}", numeroDecimal, numeroBinario);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("\n\t\t\tBINARIO A DECIMAL\n");
                Console.Write("Ingrese un numero Binario: ");
                numeroBinario = Console.ReadLine();
                numeroDecimal = Conversor.BinarioDecimal(numeroBinario);
                Console.WriteLine("El numero binario {0} se convirtio en decimal: {1}", numeroBinario,numeroDecimal);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t\t\tLA OPCION ELEGIDA NO ES CORRECTA!");
            }

            Console.ReadLine();
        }
    }
}
