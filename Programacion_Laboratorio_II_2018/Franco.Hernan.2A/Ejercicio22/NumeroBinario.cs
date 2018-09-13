using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class NumeroBinario
    {
        #region Atributos
        public string numero;
        #endregion

        #region Constructor
        public NumeroBinario(string n)
        {
            this.numero = n;
        }
        #endregion

        #region Metodos

        public static NumeroBinario operator +(NumeroBinario B, NumeroDecimal D)
        {
            string numero = "";
            if (!object.Equals(B, null) && !object.Equals(D, null))
            {
                numero = Conversor.DecimalBinario(D.numero);

                return B.numero + numero;
            }
            else
            {
                return null;
            }
        }

        public static NumeroBinario operator -(NumeroBinario B, NumeroDecimal D)
        {
            string numero = "";
            if (!object.Equals(B, null) && !object.Equals(D, null))
            {
                numero = Conversor.DecimalBinario(D.numero);

                return B.numero - numero;
            }
            else
            {
                return null;
            }
        }

        public static string operator -(string A, string B)
        {
            return A - B;
        }

        public static implicit operator NumeroBinario(string N)
        {
            return (NumeroBinario)N;
        }

        #endregion
    }
}
