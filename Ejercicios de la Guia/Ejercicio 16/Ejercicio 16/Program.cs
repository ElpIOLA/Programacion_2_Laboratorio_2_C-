using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno();
            Alumno a2 = new Alumno();
            Alumno a3 = new Alumno();

            a1.nombre = "Hernan";
            a1.apellido = "Franco";
            a1.legajo = 1234;

            a1.Estudiar(7, 4);
            Console.WriteLine(a1.Mostrar());

            Console.ReadKey();

            a2.nombre = "Lautaro";
            a2.apellido = "Aquino";
            a2.legajo = 4321;

            a2.Estudiar(5, 8);
            Console.WriteLine(a2.Mostrar());

            Console.ReadKey();

            a3.nombre = "Aylen";
            a3.apellido = "Moreno";
            a3.legajo = 2357;

            a3.Estudiar(8, 8);
            Console.WriteLine(a3.Mostrar());

            Console.ReadKey();
        }
    }
}
