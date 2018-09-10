using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Pesos
    {
        #region Atributos
        private double cantidad;
        private float cotizeRespectoDolar;
        #endregion

        #region Constructor
        public Pesos()
        {
            cantidad = 0;
            cotizeRespectoDolar = 0;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            this.cotizeRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            if (!Object.Equals(p1, null) && !Object.Equals(p2, null))
            {
                if (p1 == p2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            if (!Object.Equals(p1, null) && !Object.Equals(p2, null))
            {
                if (p1 != p2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Pesos p1, Euro e)
        {
            if (!Object.Equals(p1, null) && !Object.Equals(e, null))
            {
                if (p1 == e)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Pesos p1, Euro e)
        {
            if (!Object.Equals(p1, null) && !Object.Equals(e, null))
            {
                if (p1 != e)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Pesos p1, Dolar d)
        {
            if (!Object.Equals(p1, null) && !Object.Equals(d, null))
            {
                if (p1 == d)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Pesos p1, Dolar d)
        {
            if (!Object.Equals(p1, null) && !Object.Equals(d, null))
            {
                if (p1 != d)
                {
                    return true;
                }
            }
            return false;
        }

        public static Pesos operator +(Pesos p1, Dolar d)
        {
            Pesos retorno = new Pesos();
            if (!Object.Equals(p1, null) && !Object.Equals(d, null))
            {
                retorno = p1 + d;
            }
            return retorno;
        }

        public static Pesos operator +(Pesos p1, Euro e)
        {
            Pesos retorno = new Pesos();
            if (!Object.Equals(p1, null) && !Object.Equals(e, null))
            {
                retorno = p1 + e;
            }
            return retorno;
        }

        public static Pesos operator -(Pesos p1, Dolar d)
        {
            Pesos retorno = new Pesos();
            if (!Object.Equals(p1, null) && !Object.Equals(d, null))
            {
                retorno = p1 - d;
            }
            return retorno;
        }

        public static Pesos operator -(Pesos p1, Euro e)
        {
            Pesos retorno = new Pesos();
            if (!Object.Equals(p1, null) && !Object.Equals(e, null))
            {
                retorno = p1 - e;
            }
            return retorno;
        }

        public static implicit operator Pesos(double d)
        {
            Pesos peso = new Pesos();
            return peso.cantidad = d;
        }

        public float GetCotizacionD()
        {
            return (float)this.cantidad * this.cotizeRespectoDolar;
        }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)p;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return (Dolar)p;
        }

        #endregion
    }
}
