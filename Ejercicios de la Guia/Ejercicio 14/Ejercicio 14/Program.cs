using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado = 0,
                vase = 0,
                altura = 0,
                radio = 0;

            Console.Write("Ingrese lado: ");
            lado = double.Parse(Console.ReadLine());

            Console.WriteLine("El area de un Cuadrado es: {0}", CalculoDeArea.CalcularCuadrado(lado));

            Console.ReadKey();

            Console.Write("Ingrese base: ");
            vase = double.Parse(Console.ReadLine());

            Console.Write("Ingrese altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("El area de un Triangulo es: {0}", CalculoDeArea.CalcularTriangulo(vase,altura));

            Console.ReadKey();

            Console.Write("Ingrese radio: ");
            radio = double.Parse(Console.ReadLine());

            Console.WriteLine("El area de un Circulo es: {0}", CalculoDeArea.CalcularCirculo(radio));

            Console.ReadKey();
        }
    }
}
