using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercial : Avion, IARBA
    {
        protected int _capacidadPasajeros;

        public Comercial(double precio, double velocidad, int pasajeros)
            : base(precio,velocidad)
        {
            _capacidadPasajeros = pasajeros;
        }

        public new int PropiedadInt
        {
            get { return _capacidadPasajeros; }
            set { _capacidadPasajeros = value; }
        }

        double IARBA.CalcularImpuesto()
        {
            double impuesto = (_precio * 0.25 / 100);
            return impuesto;
        }
    }
}
