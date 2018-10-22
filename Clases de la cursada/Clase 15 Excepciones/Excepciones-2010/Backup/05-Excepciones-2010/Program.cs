﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Excepciones_2010
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("1.-Excepción propia");
                    Console.WriteLine("2.-Excepción propia, desde un catch");
                    Console.WriteLine("3.-Excepción propia, manteniendo la excepción original");
                    Console.WriteLine();

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            throw new MiClaseException("Lanzo una excepción propia!!!");
                            break;
                        case "2":
                            Console.WriteLine("Ingrese un número:");

                            int i = int.Parse(Console.ReadLine());
                            break;
                        case "3":
                            Console.WriteLine("Ingrese un número distinto de cero:");

                            int k = int.Parse(Console.ReadLine());

                            Console.WriteLine(1/k);

                            break;
                        default:
                            break;
                    }

                }

                catch (MiClaseException ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.ReadLine();
                }

                catch (FormatException)
                {
                    throw new MiClaseException("Ingrese un número!!!\nTenga cuidado!!!");
                }

                catch (DivideByZeroException ex)
                {
                    throw new MiClaseException("Ingrese un número distinto de cero!!!" +
                                               "\nTenga cuidado!!!", ex);

                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                if (e.InnerException != null)
                {
                    Console.Write("Excepción original: ");
                    Console.WriteLine(e.InnerException.Message);
                }

                Console.ReadLine();
            }
        }
    }
}
