using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0,
                n2 = 0,
                resultado = 0;
            char operador;


            Console.Write("Ingrese el primer numero: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese operador: ");
            operador = char.Parse(Console.ReadLine());

            resultado = Calculadora.Calcular(n1, n2, operador);

            Console.Write(Calculadora.Mostrar(resultado));

            Console.ReadKey();
        }
    }
}
