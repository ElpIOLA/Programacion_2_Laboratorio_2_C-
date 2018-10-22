using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    class PrestamoDolar : Prestamo
    {
        #region Atributos
        private PeriodicidadDePago _periocidad;
        #endregion

        #region Propiedades
        public float Interes
        {
            get { return this.CalcularInteres(); }
        }

        public PeriodicidadDePago Periocidad
        {
            get { return this._periocidad; }
        }
        #endregion

        #region Constructor
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePago periodicidad) : base(monto,vencimiento)
        {
            this._periocidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePago periodicidad) 
            : this(prestamo.Monto, prestamo.Vencimiento, periodicidad) { }
        #endregion

        #region Metodos
        private float CalcularInteres()
        {
            float interes = 0;

            if(this._periocidad is PeriodicidadDePago.Mensual)
            {
                interes = 25;
            }
            if(this._periocidad is PeriodicidadDePago.Bimestral)
            {
                interes = 35;
            }
            if(this._periocidad is PeriodicidadDePago.Trimestral)
            {
                interes = 40;
            }

            return interes;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar(), " - Porcentaje de Interes: {0}", this.Interes, " - Tipo de pago: {1}\n", this._periocidad);
            return sb.ToString();
        }

        public override void ExtenerPlazo(DateTime nuevoVencimiento)
        {
            float nuevoInteres = 0;

            nuevoInteres = (float)(this.Interes * 2.5) * Convert.ToInt32(nuevoVencimiento);

            this._vencimiento = nuevoVencimiento;
        }
        #endregion
    }
}
