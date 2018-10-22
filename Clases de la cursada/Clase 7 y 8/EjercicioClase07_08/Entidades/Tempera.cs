using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tempera
    {
        #region Atributos
        private sbyte _cantidad;
        private ConsoleColor _color;
        private string _marca;
        #endregion

        #region Constructor
        public Tempera(sbyte cantidad, ConsoleColor color, string marca)
        {
            this._cantidad = cantidad;
            this._color = color;
            this._marca = marca;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            return String.Format("\nCantidad: " + this._cantidad + " Color: " + this._color + " Marca: " + this._marca);
        }
        #endregion

        #region Propiedades

        public sbyte GetCantidad { get { return this._cantidad; } }
        public ConsoleColor GetColor { get { return this._color; } }
        public string GetMarca { get { return this._marca; ; } }

        #endregion

        #region SobreCargas
        public static implicit operator string(Tempera T)
        {
            return T.Mostrar();
        }

        public static explicit operator sbyte(Tempera T)
        {
            return T._cantidad;

        }

        public static bool operator ==(Tempera T1, Tempera T2)
        {
            bool retorno = false;
            if (!object.Equals(T1, null) && !object.Equals(T2, null))
            {
                if (T1._color == T2._color && T1._marca == T2._marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Tempera T1, Tempera T2)
        {
            bool retorno = false;
            if (!object.Equals(T1, null) && !object.Equals(T2, null))
            {
                if (T1._color != T2._color || T1._marca != T2._marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static Tempera operator +(Tempera T, sbyte C)
        {
            if (!object.Equals(T, null))
            {
                Tempera T2 = new Tempera((sbyte)(T._cantidad + C), T._color, T._marca);
                return T2;
            }
            return null;
        }

        public static Tempera operator +(Tempera T1, Tempera T2)
        {
            if (!object.Equals(T1, null) && !object.Equals(T2, null))
            {
                Tempera T3 = new Tempera(T1._cantidad, T1._color, T1._marca);
                if (T1 == T2)
                {
                    T3 += T2._cantidad;
                    return T3;
                }
            }
            return null;
        }
        #endregion
    }
}
