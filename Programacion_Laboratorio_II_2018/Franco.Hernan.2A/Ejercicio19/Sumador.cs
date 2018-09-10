using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        #region Atributos
        private int cantidadSumas;
        #endregion

        #region Constructor

        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        #endregion

        #region Metodos

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + " " + b;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }
        #endregion
    }
}
