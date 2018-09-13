using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Estante
    {
        #region Atributos
        private Producto[] productos;
        private int ubicacionEstante;
        #endregion

        #region Constructor
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        #endregion

        #region Metodos
        public Producto[] GetProducto()
        {
            return this.productos;
        }

        public string MostrarEstante()
        {
            string retorno = "";
            for(int i = 0; i < this.productos.GetLength(0); i++)
            {
                if(this.productos.GetValue(i) != null)
                {
                    retorno += this.productos.GetValue(i);
                }
            }
            return retorno;
        }
        #endregion
    }
}
