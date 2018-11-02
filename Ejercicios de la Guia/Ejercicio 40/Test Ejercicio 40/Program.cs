using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Test_Ejercicio_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita central = new Centralita("Llamados Express");

            Local l1 = new Local("Lanus", (float)31.10, "Madrid", (float)0.78);
            Provincial p1 = new Provincial("Lima", Provincial.Franja.Franja_2, (float)25.44, "Lomas");

            central += l1;
            central += p1;

            Console.Write(central.ToString());
            Console.ReadKey();
        }
    }
}
