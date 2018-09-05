using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Tinta pluma1 = new Tinta();
        Tinta pluma2 = new Tinta();

        Console.WriteLine(Tinta.Mostrar(pluma1));
        Console.WriteLine(pluma1 == pluma2);

        Tinta pluma3 = new Tinta(ConsoleColor.Red);
        Console.WriteLine(pluma1 == pluma3);
        Console.WriteLine(pluma1 != pluma3);*/

        Tinta pluma0 = new Tinta(ConsoleColor.DarkCyan);
        Pluma lapicera = new Pluma("firuleti",50, pluma0);
        Console.Write(lapicera);

        if(lapicera == pluma0)
        {
            Console.Write("\nSon iguales!\n");
        }
        else
        {
            Console.Write("\n\tNo son iguales!\n");
        }
        Console.ReadLine();

        Tinta pluma3 = new Tinta(ConsoleColor.DarkMagenta);
        Pluma lapicera3 = new Pluma("grido", 70, pluma3);
        Console.Write(lapicera3);

        if (lapicera3 != pluma3)
        {
            Console.Write("\nSon iguales!\n");
        }
        else
        {
            Console.Write("\nNo son iguales!\n");
        }
        Console.ReadLine();

        Tinta pluma1 = new Tinta(ConsoleColor.DarkGreen);
        Pluma lapicera_1 = new Pluma("kalawa", 25, pluma1);
        Console.Write(lapicera_1);
        lapicera_1 = lapicera_1 + pluma1;
        Console.Write("\n\tSUMA\n");
        Console.Write(lapicera_1);
        Console.ReadLine();

        Tinta pluma2 = new Tinta(ConsoleColor.DarkYellow);
        Pluma lapicera_2 = new Pluma("ggg", 46, pluma2);
        Console.Write(lapicera_2);
        lapicera_2 = lapicera_2 - pluma2;
        Console.Write("\n\tRESTA\n");
        Console.Write(lapicera_2);
        Console.ReadLine();
        }
    }
}
