using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double c)
        {
            double resultado = c * c;
            return resultado;
        }

        public static double CalcularTriangulo(double vase, double altura)
        {
            double resultado = (vase * altura) / 2;
            return resultado;
        }

        public static double CalcularCirculo(double radio)
        {
            double resultado = (radio * radio) * 3.14;
            return resultado;
        }
    }
}
