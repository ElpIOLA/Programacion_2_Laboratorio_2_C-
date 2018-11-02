using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador();
            Sumador suma2 = new Sumador();

            Console.WriteLine("\n1 - {0}\n",suma.Sumar(23, 32));
            Console.WriteLine("\n2 - {0}\n", suma2.Sumar("hola", "gato"));

            Console.WriteLine("Suma entre sumadores: ", suma + suma2);

            Console.ReadKey();
        }
    }
}
