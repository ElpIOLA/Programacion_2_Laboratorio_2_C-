using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan.Franco._2A
{
    public abstract class Mascota
    {
        #region Atributos
        private string nombre;
        private string raza;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Raza
        {
            get { return this.raza; }
        }
        #endregion

        #region Constructor
        public Mascota(string name, string race)
        {
            this.nombre = name;
            this.raza = race;
        }
        #endregion

        #region Metodos
        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            return string.Format("\n Nombre: {0} - Raza: {1}", this.nombre, this.raza);
        }
        #endregion
    }
}
