using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Humano : Animal
    {
        #region Atributos
        private string _apellido;
        private string _nombre;
        private static int _piernas;
        #endregion

        #region Contructor
        static Humano()
        {
            _piernas = 2;
        }

        public Humano(int velocidadMaxima): base(_piernas, velocidadMaxima) { }

        public Humano(string nombre, string apellido, int velocidadMaxima) : this(velocidadMaxima)
        {
            this._nombre = nombre;
            this._apellido = nombre;
        }
        #endregion

        #region Metodos
        public static bool operator ==(Humano h1, Humano h2)
        {
            bool retorno = false;
            if ((h1._nombre == h2._nombre) && (h1._apellido == h2._apellido))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Humano h1, Humano h2)
        {
            return !(h1 == h2);
        }

        public string MostrarHumano()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("HUMANO");
            sb.AppendFormat("Nombre : {0}\n", this._nombre);
            sb.AppendFormat("Apellido: {0}\n", this._apellido);
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }
        #endregion
    }
}
