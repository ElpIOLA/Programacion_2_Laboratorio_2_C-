using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_4;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_3";
            char seguir = 's';
            string numeroBinario = "";
            int opcion = 0,
                numeroEntero = 0;
            bool validacion;

            Calcular calculadorEnteros = new Calcular();
            Calcular calcularBinarios = new Calcular();

            while (seguir == 's')
            {
                validacion = true;
                while (validacion)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\n\t1- Convertir de Binario a Entero");
                    Console.Write("\n\t2- Convertir de Entero a Binario");
                    Console.Write("\n\t3- Mostrar acumulacion en binario");
                    Console.Write("\n\t4- Mostrar acumulacion en Entero");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\t5- Salir");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\n\tEliga una opcion: ");
                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n\tError! La opcion ingresada no es valida.");
                        Console.ReadKey();
                    }
                    else
                    {
                        validacion = false;
                    }
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write("\n\tIngrese un numero binario: ");

                        numeroBinario = Console.ReadLine();
                        
                        numeroEntero = Conversor.BinarioEntero(numeroBinario);

                        calcularBinarios = new Calcular(numeroBinario);

                        Console.Write("\n\tNumero Binario ingresado: {0}\n\tNumero Entero recibido: {1}\n", numeroBinario, numeroEntero);
                        Console.Write("\n\tPresione Enter....\n");

                        calcularBinarios.acumular(numeroBinario);
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write("\n\tIngrese un numero Entero: ");

                        numeroEntero = int.Parse(Console.ReadLine()); 

                        numeroBinario = Conversor.EnteroBinario(numeroEntero);

                        calculadorEnteros = new Calcular(numeroEntero);

                        Console.Write("\n\tNumero Entero ingresado: {0}\n\tNumero Binario recibido: {1}\n", numeroEntero, numeroBinario);
                        Console.Write("\n\tPresione Enter....\n");
                        calculadorEnteros.acumular(numeroEntero);
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\tEl acumulador en Binario es: {0}", calcularBinarios.getResultadoBinario());
                        Console.Write("\n\tPresione Enter....\n");
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\tEl acumulador en Entero es: {0}", calculadorEnteros.getResultadoEntero());
                        Console.Write("\n\tPresione Enter....\n");
                        break;
                    case 5:
                        seguir = 'n';
                        break;
                    default:
                        Console.Write("\n\tLa opcion ingresada no es correcta!\n");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
