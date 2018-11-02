using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEjercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string nivelTinta = "";
            Boligrafo bAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo bAmarillo = new Boligrafo(ConsoleColor.Yellow, 50);

            Console.WriteLine("Nivel de tinta: {0}", bAzul.GetTinta());
            bAzul.Pintar(60, out nivelTinta);
            Console.Write("Color de tinta: {0}", bAzul.GetColor());
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("Nivel de tinta: {0}", bAzul.GetTinta());
            bAmarillo.Pintar(25, out nivelTinta);
            Console.Write("Color de tinta: {0}", bAmarillo.GetColor());

            Console.ReadKey();
        }
    }
}
