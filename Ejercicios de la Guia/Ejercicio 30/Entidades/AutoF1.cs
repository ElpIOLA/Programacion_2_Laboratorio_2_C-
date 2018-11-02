using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        #region Atributos
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;
        #endregion

        #region Propiedades
        public short CantidadCombustible
        {
            get { return this._cantidadCombustible; }
            set { this._cantidadCombustible = value; }
        }

        public short VueltasRestantes
        {
            get { return this._vueltasRestantes; }
            set { this._vueltasRestantes = value; }
        }

        public bool EnCompetencia
        {
            get { return this._enCompetencia; }
            set { this._enCompetencia = value; }
        }
        #endregion

        #region Constructor
        public AutoF1(short numero, string escuderia)
        {
            this._cantidadCombustible = 0;
            this._vueltasRestantes = 0;
            this._enCompetencia = false;
            this._numero = numero;
            this._escuderia = escuderia;
        }
        #endregion

        #region Metodo
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nEscuderia: {0}", this._escuderia);
            sb.AppendFormat("\nNumero: {0}", this._numero);
            sb.AppendFormat("\nEsta compitiendo: {0}", this._enCompetencia);
            sb.AppendFormat("\nCantidad de combustible: {0} litros", this._cantidadCombustible);
            sb.AppendFormat("\nVueltas restantes: {0}", this._vueltasRestantes);
            return sb.ToString();
        }
        #endregion

        #region SobreCarga
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if(a1._numero == a2._numero && a1._escuderia == a2._escuderia)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
