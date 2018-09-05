using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio16;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno_1 = new Alumno("Hernan","Franco",12);
            alumno_1.Estudiar(7, 6);
            alumno_1.Mostrar();
            Console.ReadLine();
        }
    }
}
