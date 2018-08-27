using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Conversor
{
    class Conversor
    {
        public static string DecimalBinario(double deci)
        {
            string binario = "";
            while(deci < 0)
            {
                binario = deci % 2 + binario;

                deci = deci / 2;
            }
            return binario;
        }

        /*public static double BinarioDecimal(string bin)
        {

        }*/
    }
}
