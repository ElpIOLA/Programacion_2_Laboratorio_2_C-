using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test_Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(22, "ford");
            AutoF1 a2 = new AutoF1(12, "volkswagen");
            AutoF1 a3 = new AutoF1(192, "peugeot");

            Competencia c = new Competencia(20, 6);

            if(c + a1)
            {
                Console.Write("\nAuto agregado a la carrera!\n");
            }
            if (c + a2)
            {
                Console.Write("\nAuto agregado a la carrera!\n");
            }
            if (c + a3)
            {
                Console.Write("\nAuto agregado a la carrera!\n");
            }

            Console.Write(c.MostrarDatos());

            Console.ReadKey();
        }
    }
}
