using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Conversor
    {
        public static string DecimalBinario(int entero)
        {
            string binario = "";
            while (entero > 0)
            {
                binario = (entero % 2).ToString() + binario;
                entero = entero / 2;
            }
            return binario;
        }

        public static int BinarioDecimal(string binario)
        {
            int entero = 0;

            for (int i = 1; i <= binario.Length; i++)
            {
                entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return entero;
        }
    }
}
