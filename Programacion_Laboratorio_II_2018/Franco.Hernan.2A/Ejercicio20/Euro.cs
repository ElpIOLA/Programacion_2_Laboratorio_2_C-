using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Euro
    {
        #region Atributos
        private double cantidad;
        private float cotizRespectoDolar;
        #endregion

        #region Constructores
        public Euro()
        {
            this.cantidad = 0;
            this.cotizRespectoDolar = 0;
        }

        public Euro(double cantidad) : this()

        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            this.cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Metodos

        public static bool operator ==(Euro e1, Euro e2)
        {
            if (!Object.Equals(e1, null) && !Object.Equals(e2, null))
            {
                if (e1 == e2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            if (!Object.Equals(e1, null) && !Object.Equals(e2, null))
            {
                if (e1 != e2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Euro e1, Pesos p)
        {
            if (!Object.Equals(e1, null) && !Object.Equals(p, null))
            {
                if (e1 == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Euro e1, Pesos p)
        {
            if (!Object.Equals(e1, null) && !Object.Equals(p, null))
            {
                if (e1 != p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Euro e1, Dolar d)
        {
            if (!Object.Equals(e1, null) && !Object.Equals(d, null))
            {
                if (e1 == d)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Euro e1, Dolar d)
        {
            if (!Object.Equals(e1, null) && !Object.Equals(d, null))
            {
                if (e1 != d)
                {
                    return true;
                }
            }
            return false;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro retorno = new Euro();
            if (!Object.Equals(e, null) && !Object.Equals(p, null))
            {
                retorno = e + p;
            }
            return retorno;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro retorno = new Euro();
            if (!Object.Equals(e, null) && !Object.Equals(d, null))
            {
                retorno = e + d;
            }
            return retorno;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro retorno = new Euro();
            if (!Object.Equals(e, null) && !Object.Equals(p, null))
            {
                retorno = e - p;
            }
            return retorno;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro retorno = new Euro();
            if (!Object.Equals(e, null) && !Object.Equals(d, null))
            {
                retorno = e - d
;
            }
            return retorno;
        }

        public static implicit operator Euro(double e)
        {
            Euro euro = new Euro();
            return euro.cantidad = e;
        }

        public float GetCotizacion()
        {
            return (float)this.cantidad * this.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return (Dolar)e;
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)e;
        }
        #endregion
    }
}
