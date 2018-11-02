using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº38 Guía 2017";
            Sobreescrito sobrecarga = new Sobreescrito();
            Console.WriteLine(sobrecarga.ToString());
            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.ReadKey();
        }

        public class Sobreescrito
        {
            public override int GetHashCode()
            {
                return 1142510187;
            }

            public override string ToString()
            {
                return string.Format("Este es mi metodo ToString Sobrecargado!");
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (GetType() == obj.GetType())
                    return true;
                else
                    return false;
            }
        }
 
    }
}
