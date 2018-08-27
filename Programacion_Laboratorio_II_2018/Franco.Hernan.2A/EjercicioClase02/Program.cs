using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EjercicioClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Sello.color = ConsoleColor.Blue;

            Sello.mensaje = "Hola Mundo";
            Sello.imprimirEnColor();
            Console.ReadLine();

            Sello.borrar();

            Sello.mensaje = "Aguante Boca";
            Console.WriteLine(Sello.imprimir());
            Console.ReadLine();
        }
    }
}
