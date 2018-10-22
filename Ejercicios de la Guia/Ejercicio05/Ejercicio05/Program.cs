using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";
            double numero = 0,
                i,
                j,
                sumaAtras,
                sumaAdelante,
                aumento = 1;
            bool flag = true;

            while(flag)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("\nIngrese un numero mayor a 1: ");
                if(double.TryParse(Console.ReadLine(),out numero))
                {
                    if(numero > 0)
                    {
                        Console.Write("\n\t----- El numero es valido. Presione Enter.. -----\n");
                        Console.ReadKey();
                        flag = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t----- El numero no es valido. Presione Enter.. -----\n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t----- El numero no es valido. Presione Enter.. -----\n");
                    Console.ReadKey();
                }
            }

            while(aumento < numero)
            {
                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                for(i = 1; i < aumento; i++)
                {
                    sumaAtras += i;
                }

                for(j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante += j;
                }

                if (sumaAtras == sumaAdelante)
                    Console.WriteLine("\nEs centro numerico: {0}", aumento);
            }

            Console.ReadKey();
        }
    }
}
