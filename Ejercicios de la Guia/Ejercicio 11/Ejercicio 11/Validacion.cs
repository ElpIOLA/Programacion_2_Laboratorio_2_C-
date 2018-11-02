using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;
            
            if(valor <= max && valor >= min)
                retorno = true;
         
            return retorno;
        }
    }
}
