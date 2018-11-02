using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        #region Atributos
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;
        public short cilindrada;
        #endregion

        #region Constructor
        public Moto(short cRueda, short cPuerta, Colores color, short cilindrada)
            : base(cRueda,cPuerta,color,cilindrada,2) {}
        #endregion

        #region Metodo
        public override string Mostrar()
        {
            return base.Mostrar();
        }
        #endregion
    }
}
