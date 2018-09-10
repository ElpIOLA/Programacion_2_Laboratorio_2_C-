using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio19;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador();

            Console.WriteLine(suma.Sumar(70, 40));
            Console.WriteLine(suma.Sumar("Hola", "mundo"));
            Console.ReadLine();

            Sumador suma_2 = new Sumador();

            Console.WriteLine(suma_2.Sumar(40, 100));
            Console.WriteLine(suma_2.Sumar("Chau", "mundo"));
            Console.ReadLine();

            Console.WriteLine(suma + suma_2);
            Console.WriteLine(suma | suma_2);
            Console.ReadLine();

        }
    }
}
