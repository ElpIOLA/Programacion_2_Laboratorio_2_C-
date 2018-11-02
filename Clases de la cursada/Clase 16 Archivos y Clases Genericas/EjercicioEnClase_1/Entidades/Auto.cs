using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        #region Atributos
        private string _color;
        private string _marca;
        #endregion

        #region Propiedades
        public string Color
        {
            get { return this._color; }
        }

        public string Marca
        {
            get { return this._marca; }
        }
        #endregion

        #region Constructor
        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        #endregion

        #region SobreCarga
        public static bool operator ==(Auto a, Auto b)
        {
            bool ret = false;
            if(a._color ==  b._color && a._marca == b._marca)
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        #endregion

        #region Polimorfismo
        public override bool Equals(Object obj)
        {
            bool ret = false;
            if(obj is Auto)
            {
                ret = (this == (Auto)obj);
            }
            return ret;
        }

        public override string ToString()
        {
            return string.Format("Marca: " + this._marca + " Color: " + this._color);
        }
        #endregion
    }
}
