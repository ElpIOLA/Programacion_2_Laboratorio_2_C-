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
            double numero;
            string respuesta;

            Console.WriteLine("Ingrese un numero: ");
            numero = double.Parse(Console.ReadLine());

            respuesta = Conversor.DecimalBinario(numero);
            Console.WriteLine("El numero {0} se convirtio en binario: {1}", numero, respuesta);
            Console.ReadLine();
        }
    }
}
