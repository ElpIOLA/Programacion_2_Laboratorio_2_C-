using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        #region Atributos
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;
        public short cantidadMarchas;
        public int cantidadPasajeros;
        #endregion

        #region Constructor
        public Automovil(short cRueda, short cPuerta, Colores color, short cMarchas, int cPasajeros)
            : base (cRueda,cPuerta,color,cMarchas,cPasajeros){}
        #endregion

        #region Metodo
        public override string Mostrar()
        {
            return base.Mostrar();
        }
        #endregion
    }
}
