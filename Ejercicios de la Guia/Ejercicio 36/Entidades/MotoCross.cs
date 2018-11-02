using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        #region Atributos
        private short _cilindrada;
        #endregion

        #region Propiedades
        public short Cilindrada
        {
            get { return this._cilindrada; }
            set { this._cilindrada = value; }
        }
        #endregion

        #region Constructor
        public MotoCross(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this._cilindrada = cilindrada;
        }
        #endregion

        #region Metodo
        public override string MostrarDato()
        {
            return base.MostrarDato() + "\nCilindradas: " + this._cilindrada;
        }
        #endregion

        #region SobreCarga
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            bool retorno = false;
            if (a1._cilindrada == a2._cilindrada && a1.Escuderia == a2.Escuderia && a1.Numero == a2.Numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
