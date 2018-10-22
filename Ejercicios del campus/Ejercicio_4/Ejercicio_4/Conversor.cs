using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Conversor
    {
        #region Metodos
        public static string EnteroBinario(int numero)
        {
            string binario = "";

            while (numero > 0)
            {
                binario = (numero % 2).ToString() + binario;
                numero = numero / 2;
            }
            if (numero < 0)
            {
                binario = "\n\tValor invalido\n";
            }
            return binario;
        }

        public static int BinarioEntero(string binario)
        {
            int[] arrayEnteros = new int[binario.Length];
            int numero = 0;

            if (binario != "1" && binario != "0")
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    arrayEnteros[i] = (int)char.GetNumericValue(binario[i]);
                }
                for (int j = 0; j < binario.Length; j++)
                {
                    numero += (int)(arrayEnteros[j] * Math.Pow(2, binario.Length - j - 1));
                }
            }
            else
            {
                Console.Write("\n\tValor invalido\n");
                Console.ReadKey();
            }
            return numero;
        }
        #endregion
    }
}
