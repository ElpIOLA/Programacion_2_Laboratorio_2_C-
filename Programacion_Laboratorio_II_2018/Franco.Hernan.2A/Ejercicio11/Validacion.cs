using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Validacion
{
    class Validacion
    {
        public static bool validar(int valor, int min, int max)
        {
            bool resultado = false;
            if((valor > min) && (valor < max))
            {
                return resultado = true;
            }else
            {
                return resultado;
            }
        }
    }
}
