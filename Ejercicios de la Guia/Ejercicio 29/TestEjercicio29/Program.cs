using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEjercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador("Hernan", 39664999,152,300);
            Jugador j2 = new Jugador("Lautaro", 39245788,100,245);

            Equipo equipo = new Equipo(11, "Boca Juniors");

            if(equipo + j1)
            {
                Console.WriteLine("Jugador agregado");
            }
            if (equipo + j2)
            {
                Console.WriteLine("Jugador agregado");
            }

            Console.Write(j1.MostrarDatos());
            Console.Write(j2.MostrarDatos());

            Console.ReadKey();
        }
    }
}
