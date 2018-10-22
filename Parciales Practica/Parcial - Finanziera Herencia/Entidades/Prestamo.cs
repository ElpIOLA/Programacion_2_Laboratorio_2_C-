using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public enum TipoDePrestamo { Pesos, Dolares, Todos}
    public enum PeriodicidadDePago { Mensual, Bimestral, Trimestral}

    abstract class Prestamo
    {
        #region Atributos
        protected float _monto;
        protected DateTime _vencimiento;
        #endregion

        #region Propiedades
        public float Monto
        {
            get { return this._monto; }
        }

        public DateTime Vencimiento
        {
            get { return this._vencimiento; }
            set
            {
                int indice = DateTime.Compare(_vencimiento, DateTime.Today);
                if(indice == 1)
                {
                    this._vencimiento = value;
                }
                else
                {
                    this._vencimiento = DateTime.Today;
                }
            }
        }
        #endregion

        #region Constructor
        public Prestamo(float monto, DateTime vencimiento)
        {
            this._monto = monto;
            this._vencimiento = vencimiento;
        }
        #endregion

        #region Metodos
        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return DateTime.Compare(p1._vencimiento, p2._vencimiento);
        }

        public abstract void ExtenerPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nMonto: " + this._monto + " - Vencimiento: " + this._vencimiento);
            return sb.ToString();
        }
        #endregion
    }
}
