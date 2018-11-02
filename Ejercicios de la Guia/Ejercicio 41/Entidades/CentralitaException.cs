using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentralitaException : Exception
    {
        #region Atributo
        private string _nombreClase;
        private string _nombreMetodo;
        #endregion

        #region Propiedades
        public Exception ExceptionInterna
        {
            get { }
        }

        public string NombreClase
        {
            get { return this._nombreClase; }
        }

        public string NombreMetodo
        {
            get { return this._nombreMetodo; }
        }
        #endregion

        #region Constructor
        public CentralitaException(string mensaje, string clase, string metodo)
            : base(mensaje)
        { 
            try
            {
                this._nombreClase = clase;
                this._nombreMetodo = metodo;
            }
            catch(Exception e)
            {

            }
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }
        #endregion
    }
}
