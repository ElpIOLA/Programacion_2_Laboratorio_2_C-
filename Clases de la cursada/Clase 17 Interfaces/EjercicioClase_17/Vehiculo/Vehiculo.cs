using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region Atributos
        protected double _precio;
        #endregion

        #region Constructor
        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
        #endregion

        #region Metodo
        public void MostrarPrecio()
        {
            Console.Write("\nPrecio: ${0:0.00}", _precio);
        }
        #endregion
    }
}
