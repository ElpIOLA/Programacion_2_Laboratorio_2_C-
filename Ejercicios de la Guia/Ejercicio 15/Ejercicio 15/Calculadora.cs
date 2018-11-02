using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double n1, double n2, char ope)
        {
            double resultado;

            if (ope == '+')
                return resultado = n1 + n2;
            if (ope == '-')
                return resultado = n1 - n2;
            if (ope == '*')
                return resultado = n1 * n2;
            if (ope == '/')
            {
                if (Calculadora.Validar(n2))
                    return resultado = n1 / n2;
                else
                    return -1;
            }
                

            return -1;
        }

        private static bool Validar(double n2)
        {
            if (n2 != 0)
                return true;

            return false;
        }

        public static string Mostrar(double resultado)
        {
            return string.Format("El resultado es {0}", resultado);
        }
    }
}
