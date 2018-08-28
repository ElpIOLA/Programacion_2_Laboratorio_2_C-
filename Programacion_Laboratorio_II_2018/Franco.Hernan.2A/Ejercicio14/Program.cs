using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa_CalculoDeArea;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14 Calculo de Area";
            Console.WriteLine("\n\t\t\tEJERCICIO 14 CALCULOS DE AREAS\n");
            int opcion = 0;
            double numero;
            double area;
            double altura;
            double vase;
            
            while (opcion != 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t¿Que desea convertir?\n\n\t[1]-Calcular Cuadrado\n\n\t[2]-Calcular Triangulo\n\n\t[3]-Calcular Circulo\n\n\t[4]-Salir\n\n\tRespuesta: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("\n\t\tCALCULAR AREA DE UN CUADRADO\n");

                        Console.Write("\n\tIngrese un numero: ");
                        numero = double.Parse(Console.ReadLine());

                        area = CalculoDeArea.CalcularCuadrado(numero);
                        if (area == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n\t\tNO SE PUEDE CALCULAR!\n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n\t\tEL AREA DE UN CUADRADO DE {0} ES: {1}\n", numero, area);
                        }
                        break;
                    case 2:
                        Console.Write("\n\t\tCALCULAR EL AREA DE UN TRIANGULO\n");

                        Console.Write("\n\tIngrese la base: ");
                        vase = double.Parse(Console.ReadLine());

                        Console.Write("\n\tIngrese la altura: ");
                        altura = double.Parse(Console.ReadLine());

                        area = CalculoDeArea.CalcularTriangulo(vase, altura);
                        if (area == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n\t\tNO SE PUEDE CALCULAR!\n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n    EL AREA DE UN TRIANGULO QUE TIENE UNA BASE DE {0} Y ALTURA DE {1} ES DE: {2}\n", vase, altura, area);
                        }
                        break;
                    case 3:
                        Console.Write("\n\t\tCALCULAR EL AREA DE UN CIRCULO\n");

                        Console.Write("\n\tIngrese el radio: ");
                        numero = double.Parse(Console.ReadLine());

                        area = CalculoDeArea.CalcularCirculo(numero);
                        if (area == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n\t\tNO SE PUEDE CALCULAR!\n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\n\t\tEL AREA DE UN CIRCULO DE {0} ES DE: {1:0.00}\n",numero,area);
                        }
                        break;
                    case 4:
                        opcion = 4;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\tLA OPCION ELEGIDA NO ES CORRECTA!");
                        break;
                }
            }
            

            Console.ReadLine();
        }
    }
}
