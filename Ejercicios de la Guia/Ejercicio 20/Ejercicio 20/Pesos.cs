using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Pesos
    {
        #region Atributos
        private double _cantidad;
        private float _cotizRespectoDolar;
        #endregion

        #region Constructor
        private Pesos()
        {

        }

        public Pesos(int capacidad) : this()
        {
            this._cantidad = capacidad;
        }

        public Pesos(int capacidad, float cotizacion) : this(capacidad)
        {
            this._cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public float GetCotizacion()
        {
            return this._cotizRespectoDolar;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool retorno = false;
            if (p1._cantidad == p2._cantidad && p1._cotizRespectoDolar == p2._cotizRespectoDolar)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Pesos p1, Euro e1)
        {
            bool retorno = false;
            if (p1._cantidad == p2._cantidad && p1._cotizRespectoDolar == p2._cotizRespectoDolar)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
