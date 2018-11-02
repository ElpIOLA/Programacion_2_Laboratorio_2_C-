using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        #region Atributos
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;
        public short cantidadMarchas;
        public int pesoCarga;
        #endregion

        #region Constructor
        public Camion(short cRueda, short cPuerta, Colores color, short cMarchas, int cPeso)
            : base(cRueda,cPuerta,color,cMarchas,2)
        {
            this.pesoCarga = cPeso;
        }
        #endregion

        #region Metodo
        public override string Mostrar()
        {
            return base.Mostrar() + "\nPeso: " + this.pesoCarga + "KG";
        }
        #endregion
    }
}
