using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEjercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            SobreSobreEscrito s = new SobreSobreEscrito();

            Console.WriteLine(s.MiPropiedad);

            Console.WriteLine(s.MiMetodo());

            Console.ReadKey();
        }
    }
}
