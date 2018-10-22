using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela : Libro
    {
        #region Atributo
        public EGenero tipo;
        #endregion

        #region Constructor
        public Novela(string titulo, float precio, Autor autor, EGenero genero)
            : base(titulo,autor,precio)
        {
            this.tipo = genero;
        }
        #endregion

        #region Metodo
        public string Mostrar()
        {
            return string.Format("Tipo: {0}\n\n", this.tipo);
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Novela a, Novela b)
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

        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
        
        public static implicit operator double(Novela n)
        {
            return n._precio;
        }
        #endregion
    }
}
