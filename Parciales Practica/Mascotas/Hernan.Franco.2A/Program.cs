using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan.Franco._2A
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro("Nestor","Comun");
            Perro p2 = new Perro("Tomi", "Pitbull", 5, true);

            Gato g1 = new Gato("Saire", "Egipsio");
            Gato g2 = new Gato("Eva", "Comun");

            Grupo hogar = new Grupo("Hogar", TipoManada.Mixta);

            hogar += p1;
            hogar += p2;
            hogar += g1;
            hogar += g2;

            Console.Write(hogar);

            
            hogar -= g1;
            Console.Write(hogar);


            Console.ReadKey();
        }
    }
}
