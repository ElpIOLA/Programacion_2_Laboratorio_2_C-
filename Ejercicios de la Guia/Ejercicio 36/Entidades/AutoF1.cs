using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region Atributos
        private short _caballosDeFuerza;
        #endregion

        #region Propiedades
        public short CaballosDeFuerza
        {
            get { return this._caballosDeFuerza; }
            set { this._caballosDeFuerza = value; }
        }
        #endregion

        #region Constructor
        public AutoF1(short numero, string escuderia)
            : base(numero,escuderia)
        {
            
        }

        public AutoF1(short numero,string escuderia, short caballos) : this(numero,escuderia)
        {
            this._caballosDeFuerza = caballos;
        }
        #endregion

        #region Metodo
        public override string MostrarDato()
        {
            return base.MostrarDato() + "\nCaballos de fuerza: " + this._caballosDeFuerza;
        }
        #endregion

        #region SobreCarga
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if(a1.CaballosDeFuerza == a2.CaballosDeFuerza && a1.Escuderia == a2.Escuderia && a1.Numero == a2.Numero)
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
