using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Producto
    {
        #region Atributos
        private string codigoDeBarra;
        private string marca;
        private float precio;
        #endregion

        #region Constructor
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        #endregion

        #region Metodos
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto Product)
        {
            string retorno = "\nMarca: " + Product.marca;
            retorno = "\nPrecio: " + Product.precio;
            retorno = "\nCodigo de barra: " + Product.codigoDeBarra;
            return retorno;
        }

        public static explicit operator string(Producto Product)
        {
            return Product.codigoDeBarra;
        }

        public static bool operator ==(Producto P1, Producto P2)
        {
            bool retorno = false;
            if(P1.marca == P2.marca && P1.codigoDeBarra == P2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto P1, Producto P2)
        {
            bool retorno = false;
            if (P1.marca != P2.marca || P1.codigoDeBarra != P2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Producto Product, string marca)
        {
            bool retorno = false;
            if (Product.marca == marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto Product, string marca)
        {
            bool retorno = false;
            if (Product.marca != marca)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
