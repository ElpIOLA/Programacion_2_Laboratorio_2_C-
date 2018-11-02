using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEjercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto m1 = new Moto(2, 0, Colores.Blanco, 60);
            Console.WriteLine("\n\tMOTO");
            Console.Write(m1.Mostrar());

            Automovil a1 = new Automovil(4, 4, Colores.Gris, 120, 4);
            Console.WriteLine("\n\n\tAUTOMOVIL");
            Console.Write(a1.Mostrar());

            Camion c1 = new Camion(6, 2, Colores.Rojo, 100, 1600);
            Console.WriteLine("\n\n\tCAMION");
            Console.Write(c1.Mostrar());

            Console.ReadKey();
        }
    }
}
