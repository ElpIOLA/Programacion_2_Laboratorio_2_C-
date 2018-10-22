using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        #region
        private string _nombre;
        private string _apellido;
        #endregion

        #region Constructor
        public Autor(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Autor a, Autor b)
        {
            bool retorno = false;
            if(!object.Equals(a,null) && !object.Equals(b, null))
            {
                if (a._nombre == b._nombre && a._apellido == b._apellido)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Autor a1, Autor a2)
        {
            return !(a1 == a2);
        }

        public static implicit operator string(Autor a)
        {
            return a._nombre + "-" + a._apellido;
        }
        #endregion
    }
}
