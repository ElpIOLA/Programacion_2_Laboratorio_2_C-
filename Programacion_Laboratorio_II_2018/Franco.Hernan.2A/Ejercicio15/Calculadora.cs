using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Calculadora
{
    class Calculadora
    {
        public static double Calcular(double num_1, double num_2, char caracter)
        {
            double resultado = 0;

            if(caracter == '+')
            {
                resultado = num_1 + num_2;
            }
            else if(caracter == '-')
            {
                resultado = num_1 - num_2;
            }
            else if (caracter == '*')
            {
                resultado = num_1 * num_2;
            }
            else if (caracter == '/')
            {
                if(validar(num_2) == true)
                {
                    resultado = num_1 / num_2;
                }
            }
            return resultado;
        }

        private static bool validar(double num_2)
        {
            bool respuesta = false;

            if(num_2 != 0)
            {
                return respuesta = true;
            }
            return respuesta;
        }

        public static void Mostrar(double resultado)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\t\t\tEL RESULTADO ES: {0:0.00}\n", resultado);
        }
    }
}
