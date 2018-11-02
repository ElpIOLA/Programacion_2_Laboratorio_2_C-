using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class VehiculoTerrestre
    {
        protected short bCantidadRuedas;
        protected short bCantidadPuertas;
        protected Colores bColor;
        protected short bCantidadMarchas;
        protected int bCantidadPasajeros;

        public VehiculoTerrestre(short cRuedas, short cPuertas, Colores cColor, short cMarchas, int cPasajeros)
        {
            this.bCantidadRuedas = cRuedas;
            this.bCantidadPuertas = cPuertas;
            this.bColor = cColor;
            this.bCantidadMarchas = cMarchas;
            this.bCantidadPasajeros = cPasajeros;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nCantidad Ruedas: {0}", this.bCantidadRuedas);
            sb.AppendFormat("\nCantidad Puertas; {0}", this.bCantidadPuertas);
            sb.AppendFormat("\nColor: {0}", this.bColor);
            sb.AppendFormat("\nCantidad de marchas: {0}", this.bCantidadMarchas);
            sb.AppendFormat("\nCantidad Pasajeros: {0}", this.bCantidadPasajeros);
            return sb.ToString();
        }
    }
}
