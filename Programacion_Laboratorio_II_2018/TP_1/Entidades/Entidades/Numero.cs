using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Propiedades
        private string SetNumero
        {
            set
            {
                double aux;
                aux = ValidarNumero(value);
                numero = aux;
            }
        }
        #endregion

        #region Constructor
        public Numero() : this(0)
        {
            
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }
        #endregion

        #region Metodos
        public double ValidarNumero(string strNumero)
        {
            double retorno;
            if(double.TryParse(strNumero,out double aux))
            {
                retorno = aux;
            }
            else
            {
                retorno = 0;
            }
            return retorno;
        }

        public static double BinarioDecimal(string binario)
        {
            int[] arrayEnteros = new int[binario.Length];
            double numero = 0;

            if(binario != "1" && binario != "0")
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    arrayEnteros[i] = (int)char.GetNumericValue(binario[i]);
                }
                for (int j = 0; j < binario.Length; j++)
                {
                    numero += (arrayEnteros[j] * Math.Pow(2, binario.Length - j - 1));
                }
            }
            else
            {
                Console.Write("\n\tValor invalido\n");
                Console.ReadKey();
            }
            return numero;
        }

        public static string DecimalBinario(string numero)
        {
            string binario = "";
            int entero = int.Parse(numero);
            while (entero > 0)
            {
                binario = (entero % 2).ToString() + binario;
                entero = entero / 2;
            }
            if(entero < 0)
            {
                binario = "\n\tValor invalido\n";
            }
            return binario;
        }

        public static string DecimalBinario(double numero)
        {
            string binario = "";
            int entero = (int)numero;
            while (entero > 0)
            {
                binario = (entero % 2).ToString() + binario;
                entero = entero / 2;
            }
            if (entero < 0)
            {
                binario = "\n\tValor invalido\n";
            }
            return binario;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if(!object.Equals(n1,null) && !object.Equals(n2, null))
            {
                retorno = n1.numero + n2.numero;
            }
            return retorno;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if (!object.Equals(n1, null) && !object.Equals(n2, null))
            {
                retorno = n1.numero - n2.numero;
            }
            return retorno;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if (!object.Equals(n1, null) && !object.Equals(n2, null))
            {
                retorno = n1.numero * n2.numero;
            }
            return retorno;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if(n2.numero != 0)
            {
                if (!object.Equals(n1, null) && !object.Equals(n2, null))
                {
                    retorno = n1.numero / n2.numero;
                }
            }
            else
            {
                Console.Write("\n\tNo es posible dividir por cero.\n");
                Console.ReadKey();
            }
            return retorno;
        }
        #endregion
    }
}
