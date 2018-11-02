using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{
    class PuestoAtencion
    {
        #region 
        private static int _numeroActual;
        private Puesto _puesto;
        #endregion

        #region Constructor
        private PuestoAtencion()
        {
            _numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this._puesto = puesto;
        }
        #endregion

        #region Propiedad
        public static int NumeroActual
        {
            get
            {
                _numeroActual++;
                return _numeroActual;
            }
        }
        #endregion

        #region Metodo
        public bool Atende(Cliente cli)
        {
            bool retorno = true;
            Thread.Sleep(6000);
            return retorno;
        }
        #endregion
    }
}
