using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa_ValidarRespuesta;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            Console.ForegroundColor = ConsoleColor.Green;

            int numero;
            int acum = 0;
            int i = 0;
            bool respuesta = false;
            char pregunta;

            do
            {
                Console.Write("\n\tIngrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                acum += numero;

                Console.Write("\n\tDesea ingresar otro numero? S/N");
                Console.Write("\n\tRespuesta: ");
                pregunta = char.Parse(Console.ReadLine());

                respuesta = ValidarRespuesta.ValidaS_N(pregunta);
                if(respuesta != false)
                {
                    Console.WriteLine("\n\t\t\tLA SUMA TOTAL HASTA AHORA ES {0}", acum);
                }
                i++;
            }while (respuesta == true);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\tLA SUMA TOTAL ES: {0}", acum);
            Console.ReadLine();
        }
    }
}
