using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Atributo
        private long _dni;
        private string _nombre;
        #endregion

        #region Propiedad
        public long Dni { get { return this._dni; } set { this._dni = value; } }
        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }
        #endregion

        #region Constructor
        public Persona(string nombre)
        {
            this._nombre = nombre;
        }
        public Persona(long dni, string nombre) : this(nombre)
        {
            this._dni = dni;
        }
        #endregion

        #region Metodo
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0}", this._nombre);
            sb.AppendFormat("\nDni: {0}", this._dni);
            return sb.ToString();
        }
        #endregion
    }
}
