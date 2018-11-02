using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familiar : Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente, int asientos)
            : base(precio, patente)
        {
            _cantAsientos = asientos;
        }

        public int CantidadAsientos
        {
            get { return _cantAsientos; }
            set { _cantAsientos = value; }
        }
    }
}
