using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class SobreEscrito
    {
        #region Atributo
        protected string miAtributo;
        #endregion

        #region Propiedad
        public abstract string MiPropiedad { get; }
        #endregion

        #region Constructor
        public SobreEscrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        #endregion

        #region Metodo
        public abstract string MiMetodo();
        #endregion

        #region Polimorfismo
        public override int GetHashCode()
        {
            return 1142510187;
        }

        public override string ToString()
        {
            return string.Format("Este es mi metodo ToString Sobrecargado!");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() == obj.GetType())
                return true;
            else
                return false;
        }
        #endregion
    }
}
