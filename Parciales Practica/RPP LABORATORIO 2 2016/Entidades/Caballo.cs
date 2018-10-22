using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : Animal
    {
        #region Atributos
        private string _nombre;
        private static int _patas;
        #endregion

        #region Constructor
        static Caballo()
        {
            _patas = 4;
        }

        public Caballo(string nombre, int velocidadMaxima) : base(_patas, velocidadMaxima)
        {
            this._nombre = nombre;
        }
        #endregion

        #region Metodos
        public static bool operator ==(Caballo c1, Caballo c2)
        {
            bool retorno = false;
            if(c1._nombre == c2._nombre)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Caballo c1, Caballo c2)
        {
            return !(c1 == c2);
        }

        public string MostrarCaballo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Caballo");
            sb.AppendFormat("Nombre : {0}\n", this._nombre);

            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }
        #endregion
    }
}
