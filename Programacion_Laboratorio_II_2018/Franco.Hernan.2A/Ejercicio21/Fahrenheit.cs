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
        #endregion

        #region Constructor
        public Fahrenheit(Celsius celsius)
        {
            this._celsius = celsius;
        }

        public Fahrenheit(Kelvin kelvin)
        {
            this._kelvin = kelvin;
        }
        #endregion

        #region Metodos
        public Fahrenheit CalcularC(Celsius celsius)
        {
            Fahrenheit F = new Fahrenheit(celsius);
            return F = this._celsius * (9 / 5) + 32;
        }

        public static explicit operator Fahrenheit(Celsius C)
        {
            return (Fahrenheit)C;
        }

        public static Fahrenheit operator *(Celsius C, int N)
        {
            Fahrenheit F = new Fahrenheit(C);
            F = C.F * N;
            return F;
        }
        #endregion
    }
}
