using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        #region Atributo
        private int _cantidadSumas;
        #endregion

        #region Constructores
        public Sumador()
        {
            this._cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas) : this()
        {
            this._cantidadSumas = cantidadSumas;
        }
        #endregion

        #region Metodos
        public long Sumar(long a, long b)
        {
            this._cantidadSumas++;
            Console.WriteLine("Cantiadd de sumas: {0}", this._cantidadSumas);
            long resultado = a + b;
            return resultado;
        }

        public string Sumar(string a, string b)
        {
            this._cantidadSumas++;
            Console.WriteLine("Cantiadd de sumas: {0}", this._cantidadSumas++);
            string resultado = a + " " + b;
            return resultado;
        }

        public static explicit operator int(Sumador s)
        {
            return s._cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1._cantidadSumas + s2._cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;
            if (s1._cantidadSumas == s2._cantidadSumas)
                retorno = true;

            return retorno;
        }
        #endregion
    }
}
