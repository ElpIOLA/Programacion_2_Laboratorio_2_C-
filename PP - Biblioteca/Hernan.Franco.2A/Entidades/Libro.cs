using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        #region Atributos
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;
        #endregion

        #region Constructor
        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }

        public Libro(float precio, string titulo, string nombre, string apellido)
        {
            this._autor = new Autor(nombre, apellido);
            this._precio = precio;
            this._titulo = titulo;
        }

        public Libro(string titulo, Autor autor, float precio)
        {
            this._titulo = titulo;
            this._precio = precio;
            this._autor = autor;
        }
        #endregion

        #region Propiedad
        public int CantidadDePaginas
        {
            get
            {
                if(this._cantidadDePaginas == 0)
                {
                    this._cantidadDePaginas = Libro._generadorDePaginas.Next(10,580);
                }
                return this._cantidadDePaginas;
            }
        }
        #endregion

        #region Metodos
        private static string Mostrar(Libro L)
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("\nTitulo: " + L._titulo);
            s.AppendFormat("\nPrecio: " + L._precio);
            s.AppendFormat("\nPaginas: " + L.CantidadDePaginas);
            s.AppendFormat("\nAutor: " + L._autor);
            return s.ToString();
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Libro a, Libro b)
        {
            bool retorno = false;
            if(!object.Equals(a,null) && !object.Equals(b,null))
            {
                if(a._titulo == b._titulo && a._autor == b._autor)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }

        public static explicit operator string(Libro L)
        {
            return Mostrar(L);
        }
        #endregion
    }
}
