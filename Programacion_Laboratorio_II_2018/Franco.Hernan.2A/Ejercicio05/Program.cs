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
            Console.Title = "Ejercicio 05 Centro Numerico";
            Console.WriteLine("Calculo centro numerico\n\n");

            double aumento = 1,
                numero,
                i,
                j,
                sumaAtras,
                sumaAdelante;

            Console.Write("Ingrese numero: ");
            numero = int.Parse(Console.ReadLine());

            while(aumento < numero)
            {
                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                //Calculo para atras
                for (i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                }

                //Calculo para adelante
                for (j = aumento; j <= sumaAtras; j++)
                {
                    if((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante = sumaAdelante + j;
                }

                // Mostrando en pantalla
                if (sumaAtras == sumaAdelante)
                    Console.WriteLine("Es centro numerico: {0}", aumento);
            }
            Console.ReadLine();
        }
    }
}
