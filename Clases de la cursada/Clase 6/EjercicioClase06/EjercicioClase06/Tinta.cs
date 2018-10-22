using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Tinta
    {
        #region Atributos

        private ConsoleColor _color;
        private ETipoTinta _tipo;
        #endregion

        #region Constructores
        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.conBrillito;
        }

        public Tinta(ConsoleColor color) : this()
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this._tipo = tipo;
        }
        #endregion

        #region Metodos
        public static string Mostrar(Tinta objeto)
        {
            if (!Object.Equals(objeto, null))
                return objeto.Mostrar();
            return "Tinta Null";
        }

        private string Mostrar()
        {
            Console.BackgroundColor = this._color;
            return "Color: " + this._color.ToString() + "\nTinta: " + this._tipo.ToString();
        }

        public static bool operator ==(Tinta obj1, Tinta obj2)
        {
            if(obj1._color == obj2._color && obj1._tipo == obj2._tipo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tinta obj1, Tinta obj2)
        {
            return !(obj1 == obj2);
        }
        #endregion
    }

    class Pluma
    {
        #region Atributos
        private string _marca;
        private int _cantidad;
        private Tinta _tinta;
        #endregion

        #region Constructores
        public Pluma()
        {
          this._marca = "Sin Marca";
          this._cantidad = 0;
          this._tinta = null;
        }

        public Pluma(string m) : this()
        {
          this._marca = m;
        }

        public Pluma(int c) : this()
        {
          this._cantidad = c;
        }

        public Pluma(Tinta t) : this()
        {
          this._tinta = t;
        }

        public Pluma(string m, int c) : this(m)
        {
          this._cantidad = c;
        }

        public Pluma(string m, Tinta t) : this(m)
        {
          this._tinta = t;
        }

        public Pluma(int c, Tinta t) : this(c)
        {
          this._tinta = t;
        }

        public Pluma(string m, int c, Tinta t) : this(m, c)
        {
          this._tinta = t;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
          string retorno = "";
          retorno += "\nMarca: ";
          retorno += this._marca;
          retorno += "\nCantidad: ";
          retorno += this._cantidad;
          retorno += "\nTinta: ";
          retorno += Tinta.Mostrar(this._tinta);
          retorno += "\n";
          return retorno;
        }

        public static implicit operator string(Pluma lapicera)
        {
          return lapicera.Mostrar();
        }

        public static bool operator ==(Pluma lapicera, Tinta tinta)
        {
            if(!object.Equals(tinta, null))
                return lapicera._tinta == tinta;
            return false;
        }

        public static bool operator !=(Pluma lapicera, Tinta tinta)
        {
            if(!object.Equals(tinta, null))
                return !(lapicera == tinta);
            return false;
        }

        public static Pluma operator +(Pluma lapicera, Tinta tinta)
        {
            int cantidad = 0;
            if((lapicera == tinta && lapicera._cantidad < 100) || !object.Equals(tinta, null))
            {
                cantidad = lapicera._cantidad;
                cantidad += 10;
                if(cantidad < 100)
                {
                    lapicera._cantidad += 10;
                }
            }
            return lapicera;
        }

        public static Pluma operator -(Pluma lapicera, Tinta tinta)
        {
            int cantidad = 0;
            if ((lapicera == tinta && lapicera._cantidad  > 10 && lapicera._cantidad < 100) || !object.Equals(tinta,null))
            {
                cantidad = lapicera._cantidad;
                cantidad -= 10;
                if (cantidad > 0)
                {
                    lapicera._cantidad -= 10;
                }
            }
            return lapicera;
        }
        #endregion
    }
}
