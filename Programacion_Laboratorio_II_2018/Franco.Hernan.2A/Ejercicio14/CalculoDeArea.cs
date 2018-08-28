using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_CalculoDeArea
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            double area = 0;

            if(numero != 0)
            {
                area = numero * numero;
                return area;
            }
            return area;
        }

        public static double CalcularTriangulo(double vase, double altura)
        {
            double area = 0;

            if(vase != 0 || altura != 0)
            {
                area = (vase * altura) / 2;
                return area;
            }

            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            double area = 0;
            if(radio > 0)
            {
                area = Math.PI * radio * radio;
                return area;
            }

            return area;
        }
    }
}
