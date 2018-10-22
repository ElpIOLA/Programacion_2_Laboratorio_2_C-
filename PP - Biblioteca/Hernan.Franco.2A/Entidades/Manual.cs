using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        #region Atributo
        public ETipo tipo;
        #endregion

        #region Constructor
        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo)
            : base(precio,titulo,nombre,apellido)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Metodo
        public string Mostrar()
        {
            return string.Format("Tipo: {0}\n\n",this.tipo);
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Manual a, Manual b)
        {
            bool retorno = false;
            if(!object.Equals(a,null) && !object.Equals(b,null))
            {
                if((Libro)a == (Libro)b && a.tipo == b.tipo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
 
        public static implicit operator double(Manual m)
        {
            return m._precio;
        }
        #endregion
    }
}
