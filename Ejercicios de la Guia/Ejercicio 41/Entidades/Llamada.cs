using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas,
    }

    public abstract class Llamada
    {
        #region Atributos
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region Propiedades
        public float Duracion
        {
            get { return this._duracion; }
        }

        public string NumeroDestino
        {
            get { return this._nroDestino; }
        }

        public string NumeroOrigen
        {
            get { return this._nroOrigen; }
        }

        public abstract float CostoLlamado { get; }
        #endregion

        #region Constructor
        public Llamada(float duracion, string destino, string origen)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }
        #endregion

        #region Metodo
        public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            return String.Compare(l1.Duracion.ToString(), l2.Duracion.ToString());
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nDuracion: {0}", this._duracion);
            sb.AppendFormat("\nDestino: {0}", this._nroDestino);
            sb.AppendFormat("\nOrigen: {0}", this._nroOrigen);
            return sb.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool ret = false;
            if(l1.Equals(l2) && l1.NumeroDestino == l2.NumeroDestino && l1.NumeroOrigen == l2.NumeroOrigen)
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion
    }
}
