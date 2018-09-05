using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio17;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo = "";

            Biografo lapicera_1 = new Biografo(ConsoleColor.Blue,100);
            lapicera_1.Pintar(10,out dibujo);
            Console.ReadLine();

            Biografo lapicera_2 = new Biografo(ConsoleColor.Red, 50);
            lapicera_2.Pintar(30, out dibujo);
            Console.ReadLine();
        }
    }
}
