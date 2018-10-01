using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Producto
    {
        #region Atributos
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;
        #endregion

        #region Constructor
        public Producto(string marca, string codigo, float precio)
        {
            _codigoDeBarra = codigo;
            _marca = marca;
            _precio = precio;
        }
        #endregion

        #region Metodos
        public string GetMarca()
        {
            return _marca;
        }

        public float GetPrecio()
        {
            return _precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return "\n\tMarca: " + p._marca + " \n\tPrecio: " + p._precio + " \n\tCodigo de barra: " + p._codigoDeBarra;
        }
        #endregion

        #region Sobrecargas
        public static explicit operator string(Producto p)
        {
            if(!object.Equals(p,null))
                return (string)p._codigoDeBarra;
            return null;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if(!object.Equals(p1,null) && !object.Equals(p2,null))
            {
                if(p1._marca == p2._marca && p1._codigoDeBarra == p2._codigoDeBarra)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (!object.Equals(p1, null) && !object.Equals(p2, null))
            {
                if (p1._marca != p2._marca || p1._codigoDeBarra != p2._codigoDeBarra)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator ==(Producto p1, string marca)
        {
            bool retorno = false;
            if (!object.Equals(p1, null) && marca.Length > 0)
            {
                if (p1._marca == marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            bool retorno = false;
            if (!object.Equals(p1, null) && marca.Length > 0)
            {
                if (p1._marca != marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
