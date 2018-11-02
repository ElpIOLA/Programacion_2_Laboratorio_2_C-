using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        #region Atributo
        protected float _costo;
        #endregion

        #region Propiedad
        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        #endregion

        #region Constructor
        public Local(Llamada llamada, float costo) : this(llamada.NumeroOrigen,llamada.Duracion,llamada.NumeroDestino,costo) { }
            
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion,destino,origen)
        {
            this._costo = costo;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return this.Duracion * this._costo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("\nCosto: ${0:0.00}",this.CostoLlamada);
            return sb.ToString();
        }
        #endregion
    }
}
