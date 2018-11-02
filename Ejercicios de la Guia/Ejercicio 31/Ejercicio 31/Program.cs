using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1,"Hernan");
            Cliente c2 = new Cliente(2, "Aylen");

            Negocio n = new Negocio("Farmacia");

            if (n + c1)
                Console.WriteLine("Cliente uno agregado");
            if (n + c2)
                Console.WriteLine("Cliente dos agregado");

            PuestoAtencion puesto2 = new PuestoAtencion(Puesto.Caja2);

            puesto2.Atende(c1);

            Console.ReadKey();
        }
    }
}
