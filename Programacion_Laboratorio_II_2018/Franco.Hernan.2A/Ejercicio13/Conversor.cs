using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Conversor
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string binario = "";

            while (true) //Bucle infinito.
            {
                if (((int)numero % 2) != 0) //Comprobamos si hay residuo.
                    binario = "1" + binario; //Si hay residuo en la division se agregara un numero 1 al inicio de la cadena.
                else
                    binario = "0" + binario; //Si no hay residuo se agregara 0 en lugar de 1 al inicio de la cadena.
                numero /= 2;
                if ((int)numero <= 0) //Le ponemos un limite al bucle.  
                    break;
            }   
            return binario;
        }

        public static double BinarioDecimal(string bin)
        {
            int numero = 0;
            bool flag = true;

            for(int i = bin.Length - 1, j = 0; i >= 0; i--, j++) //Ciclo for con dos incrementos.
            {
                if(bin[i] == '0' || bin[i] == '1') //Verificamos que sea un numero binario.
                {
                    numero += (int)(int.Parse(bin[i].ToString()) * Math.Pow(2,j)); //Calculamos el numero.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\t\tEL NUMERO NO ES BINARIO");
                    flag = false;
                }
            }
            return (double)numero;
        }
    }
}
