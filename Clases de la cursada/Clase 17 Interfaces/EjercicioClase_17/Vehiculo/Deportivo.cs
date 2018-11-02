using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosDeFuerza;

        public Deportivo(double precio, string patente, int fuerza)
            : base(precio, patente)
        {
            _caballosDeFuerza = fuerza;
        }

        public double PropiedadDouble { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int PropiedadInt
        {
            get { return _caballosDeFuerza; }
            set { _caballosDeFuerza = value; }
        }

        double IAFIP.CalcularImpuesto()
        {
            double impuesto = (_precio * 0.28 / 100);
            return impuesto;
        }

        double IARBA.CalcularImpuesto()
        {
            double impuesto = (_precio * 0.23 / 100);
            return impuesto;
        }
    }
}
