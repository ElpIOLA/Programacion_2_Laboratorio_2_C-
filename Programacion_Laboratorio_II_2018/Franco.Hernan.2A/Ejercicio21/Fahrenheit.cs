using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Fahrenheit
    {
        #region Atributos
        private Celsius _celsius;
        private Kelvin _kelvin;
        private float valor = 9 / 5;
        #endregion

        #region Constructor
        public Fahrenheit()
        {
            this._celsius = null;
            this._kelvin = null;
        }

        public Fahrenheit(Celsius c)
        {
            this._celsius = c;
        }

        public Fahrenheit(Celsius c, float valor) : this (c)
        {
            this.valor = valor;
        }

        public Fahrenheit(Kelvin kelvin)
        {
            this._kelvin = kelvin;
        }
        #endregion

        #region Metodos

        public Fahrenheit calcular(Celsius C, float valor)
        {
            if (!object.Equals(C, null))
            {
                Fahrenheit F = new Fahrenheit(C.valor * valor);
                return F;
            }
            return null;
        }

        public static Fahrenheit operator ++(Fahrenheit F)
        {
            return F++;
        }
        #endregion
    }
}
