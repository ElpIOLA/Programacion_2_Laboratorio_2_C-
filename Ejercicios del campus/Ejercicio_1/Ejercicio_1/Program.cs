using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            int numero = 0,
                maximo = 0,
                minimo = 0,
                acumulador = 0;
            float promedio = 0;
            bool flag = true,
                 validacion;

            for(int i = 1; i <= 5; i++)
            {
                validacion = true;
                
                while (validacion)
                {
                    Console.Clear();
                    Console.Write("\n\n{0}- Ingrese un numero: ", i);
                    if (!int.TryParse(Console.ReadLine(),out numero))
                    {
                        Console.Write("\nError! El numero ingresado no es valido!");
                        Console.ReadKey();
                    }
                    else
                    {
                        validacion = false;
                    }
                }
                acumulador += numero;


                if(flag)
                {
                    maximo = numero;
                    minimo = numero;
                    flag = false;
                }

                if(numero > maximo)
                {
                    maximo = numero;
                }
                if(numero < minimo)
                {
                    minimo = numero;
                }
            }

            //Mostramos maximo, minimo y promedio
            Console.WriteLine("\n\tEl minimo es: {0}", minimo);
            Console.WriteLine("\n\tEl maximo es: {0}", maximo);
            Console.WriteLine("\n\tEl promedio es: {0:0.00}", promedio = (float)acumulador / 5);

            Console.ReadKey();
        }
    }
}
