using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan.Franco._2A
{
    public class Gato : Mascota
    {
        #region Constructor
        public Gato(string nombre, string raza) : base(nombre,raza)
        {

        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Gato obj1, Gato obj2)
        {
            bool retorno = false;

            if(!object.Equals(obj1,null) && !object.Equals(obj2, null))
            {
                if(obj1.Nombre == obj2.Nombre && obj1.Raza == obj2.Raza)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }
        #endregion

        #region Metodos
        protected override string Ficha()
        {
            string retorno = "";

            retorno += DatosCompletos();

            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            return (this == (Gato)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
