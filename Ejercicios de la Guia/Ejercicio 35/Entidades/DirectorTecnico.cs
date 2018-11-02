using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        #region Atributo
        private DateTime _fechaNacimiento;
        #endregion

        #region Constructor
        public DirectorTecnico(string nombre) : base(nombre) { }
        public DirectorTecnico(string nombre, DateTime nacimiento) : this(nombre)
        {
            this._fechaNacimiento = nacimiento;
        }
        #endregion

        #region Metodo
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.MostrarDatos());
            sb.AppendFormat("\nFecha de nacimiento: {0}",this._fechaNacimiento);
            return sb.ToString();
        }
        #endregion

        #region SobreCarga
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            bool retorno = false;
            if (d1._fechaNacimiento == d2._fechaNacimiento)
                return retorno = true;
            return retorno;
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
        #endregion
    }
}
