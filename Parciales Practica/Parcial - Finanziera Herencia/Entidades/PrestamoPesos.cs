using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    class PrestamoPesos : Prestamo
    {
        #region Atributos
        private float _porcentajeInteres;
        #endregion

        #region Propiedades
        public float Interes
        {
            get { return this.CalcularInteres(); }
        }
        #endregion

        #region Contructores
        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto,vencimiento)
        {
            this._porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) 
            : this(prestamo.Monto,prestamo.Vencimiento,porcentajeInteres){}
        #endregion

        #region Metodos
        private float CalcularInteres()
        {
            float interes = 0;
            interes = (this.Monto * this._porcentajeInteres);
            return interes;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar(), " - Porcentaje de Interes: {0}\n", this.Interes);
            return sb.ToString();
        }

        public override void ExtenerPlazo(DateTime nuevoVencimiento)
        {
            float nuevoInteres = 0;

            nuevoInteres = (float)(this.Interes * 0.25) * Convert.ToInt32(nuevoVencimiento);

            this._porcentajeInteres = nuevoInteres;
            this._vencimiento = nuevoVencimiento;
        }
        #endregion
    }
}
