using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        #region Atributo
        protected Franja _franjaHoraria;
        #endregion

        #region Propiedad
        public override float CostoLlamado 
        {
            get { return CalcularCosto(); }
        }
        #endregion

        #region Constructor
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NumeroOrigen, miFranja, llamada.Duracion, llamada.NumeroDestino) { }

        public Provincial(string origen, Franja mifranja ,float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this._franjaHoraria = mifranja;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float resultado = 0;
            if(this._franjaHoraria == Franja.Franja_1)
            {
                resultado = this.Duracion * (float)0.99;
            }

            if(this._franjaHoraria == Franja.Franja_2)
            {
                resultado = this.Duracion * (float)1.25;
            }

            if (this._franjaHoraria == Franja.Franja_3)
            {
                resultado = this.Duracion * (float)0.66;
            }
            return resultado;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("\nFranja {0}", this._franjaHoraria);
            sb.AppendFormat("\nCosto: ${0:0.00}",this.CostoLlamado);
            return sb.ToString();
        }
        #endregion

        #region Polimorfismo
        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Provincial)
            {
                ret = true;
            }
            return ret;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
