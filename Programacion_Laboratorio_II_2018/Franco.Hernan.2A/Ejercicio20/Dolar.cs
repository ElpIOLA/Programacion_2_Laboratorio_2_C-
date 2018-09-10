using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Dolar
    {
        #region Atributos
        private double cantidad;
        private float cotizRespectoDolar;
        #endregion

        #region Constructor
        public Dolar()
        {
            this.cantidad = 0;
            this.cotizRespectoDolar = 0;
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            this.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if(!Object.Equals(d1,null) && !Object.Equals(d2, null))
            {
                if(d1 == d2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            if (!Object.Equals(d1, null) && !Object.Equals(d2, null))
            {
                if (d1 != d2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Dolar d1, Pesos p)
        {
            if (!Object.Equals(d1, null) && !Object.Equals(p, null))
            {
                if (d1 == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Dolar d1, Pesos p)
        {
            if (!Object.Equals(d1, null) && !Object.Equals(p, null))
            {
                if (d1 != p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Dolar d1, Euro e)
        {
            if (!Object.Equals(d1, null) && !Object.Equals(e, null))
            {
                if (d1.GetCotizacion() == e.GetCotizacion())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Dolar d1, Euro e)
        {
            if (!Object.Equals(d1, null) && !Object.Equals(e, null))
            {
                if (d1 != e)
                {
                    return true;
                }
            }
            return false;
        }

        public static Dolar operator +(Dolar d1, Pesos p)
        {
            Dolar retorno = new Dolar();
            if (!Object.Equals(d1, null) && !Object.Equals(p, null))
            {
                retorno = d1 + p;
            }
            return retorno;
        }

        public static Dolar operator +(Dolar d1, Euro e)
        {
            Dolar retorno = new Dolar();
            if (!Object.Equals(d1, null) && !Object.Equals(e, null))
            {
                retorno = d1 + e;
            }
            return retorno;
        }

        public static Dolar operator -(Dolar d1, Pesos p)
        {
            Dolar retorno = new Dolar();
            if (!Object.Equals(d1, null) && !Object.Equals(p, null))
            {
                retorno = d1 - p;
            }
            return retorno;
        }

        public static Dolar operator -(Dolar d1, Euro e)
        {
            Dolar retorno = new Dolar();
            if (!Object.Equals(d1, null) && !Object.Equals(e, null))
            {
                retorno = d1 - e;
            }
            return retorno;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar();
            return dolar.cantidad = d;
        }

        public float GetCotizacion()
        {  
            return (float)this.cantidad * this.cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return (Euro)d;
        }

        public static explicit operator Pesos(Dolar d)
        {
            return (Pesos)d;
        }

        #endregion
    }
}
