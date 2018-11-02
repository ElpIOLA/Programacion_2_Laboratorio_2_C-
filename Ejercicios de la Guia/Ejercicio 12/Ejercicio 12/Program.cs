using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0,
                acumular = 0,
                contador = 0;
            char seguir = 's';

            do
            {
                Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                acumular += numero;

                Console.Write("¿Desea sumar otro numero?\nSI = [s] - NO = [cualquier otra tecla]\nRespuesta: ");
                seguir = char.Parse(Console.ReadLine());
                ValidarRespuesta.ValidarS_N(seguir);
                contador++;

            } while (seguir == 's');

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Acumulacion total: {0}", acumular);
            Console.WriteLine("Cantidad de sumas: {0}", contador);

            Console.ReadKey();
        }
    }
}
