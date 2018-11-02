using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax)
            : base(precio)
        {
            _velocidadMaxima = velMax;
        }

        public virtual double PropiedadDouble
        {
            get { return _velocidadMaxima; }
            set { _velocidadMaxima = value; }
        }
        public int PropiedadInt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double CalcularImpuesto()
        {
            //throw new NotImplementedException();
            double impuesto = (_precio * 0.33 / 100);
            return impuesto;
        } 

        double IARBA.CalcularImpuesto()
        {
            double impuesto = (_precio * 0.27 / 100);
            return impuesto;
        }
    }
}
