using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClase07_08;

namespace EjercicioClase07_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 07";
            Tempera tempera_1 = new Tempera(55, ConsoleColor.DarkBlue, "China");
            Tempera tempera_2 = new Tempera(78, ConsoleColor.DarkYellow, "Argentina");

            Console.Write(tempera_1);
            Console.Write(tempera_2);

            Console.ReadLine();
        }
    }
}
