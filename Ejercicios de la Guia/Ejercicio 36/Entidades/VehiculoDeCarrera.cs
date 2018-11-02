using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
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

        public bool EnCompetencia
        {
            get { return this._enCompetencia; }
            set { this._enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return this._escuderia; }
            set { this._escuderia = value; }
        }

        public short Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public short VueltasRestantes
        {
            get { return this._vueltasRestantes; }
            set { this._vueltasRestantes = value; }
        }
        #endregion

        #region Constructor
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
        }
        #endregion

        #region Metodo
        public virtual string MostrarDato()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nEscuderia: {0}", this._escuderia);
            sb.AppendFormat("\nNumero: {0}", this._numero);
            sb.AppendFormat("\nEn competencia: {0}", this._enCompetencia);
            sb.AppendFormat("\nVueltas restantes: {0}", this._vueltasRestantes);
            sb.AppendFormat("\nCombustible: {0} litros", this._cantidadCombustible);
            return sb.ToString();
        }
        #endregion
    }
}
