using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa_Validacion;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11 Validar Numero";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\tPROGRAMA: VALIDAR NUMERO ENTRE [-100 Y 100]\n");           

            int numero;
            bool resultado;

            Console.Write("\n\tINGRESE UN NUMERO: ");
            numero = int.Parse(Console.ReadLine());
            resultado = Validacion.validar(numero, -100, 100);

            if(resultado == true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\t\tEL NUMERO ES VALIDO!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t\t\tEL NUMERO ES INVALIDO!!");
            }
            Console.ReadLine();
        }
    }
}
