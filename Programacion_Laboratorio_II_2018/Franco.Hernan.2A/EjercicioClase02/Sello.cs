using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Sello
    {
        public static string mensaje;
        
        public static ConsoleColor color;

        public static string imprimir()
        {
            return mensaje;
        }

        public static void borrar()
        {
            mensaje = "";
        }

        public static void imprimirEnColor()
        {
            Console.BackgroundColor = Sello.color;
            Console.WriteLine(Sello.mensaje);
        }
    }
}
