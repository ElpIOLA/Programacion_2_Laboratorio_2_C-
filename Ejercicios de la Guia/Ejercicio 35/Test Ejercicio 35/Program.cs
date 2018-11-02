using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test_Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t = new DateTime(1996, 10, 05);
            t.ToString("dd/MM/yyyy");
            DirectorTecnico d1 = new DirectorTecnico("Hernan",t);
            d1.Dni = 39664999;
            Console.Write("\t\tDirector Tecnico");
            Console.WriteLine(d1.MostrarDatos());

            Jugador j1 = new Jugador("Lautaro", 20, 100);
            j1.Dni = 38458999;
            Console.Write("\n\n\t\tJugador 1");
            Console.WriteLine(j1.MostrarDatos());

            Jugador j2 = new Jugador("Alen", 93, 85);
            j2.Dni = 39544788;
            Console.Write("\n\n\t\tJugador 2");
            Console.WriteLine(j2.MostrarDatos());

            Equipo e1 = new Equipo(11, "Boca Juniors");

            if(e1 + j1)
            {
                Console.WriteLine("\nJugador 1 agregado al equipo!");
            }
            else
            {
                Console.WriteLine("No se pudo agregar!");
            }

            if (e1 + j2)
            {
                Console.WriteLine("\nJugador 2 agregado al equipo!");
            }
            else
            {
                Console.WriteLine("No se pudo agregar!");
            }

            Console.ReadKey();
        }
    }
}
