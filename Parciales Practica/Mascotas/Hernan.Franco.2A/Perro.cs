using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan.Franco._2A 
{
    public class Perro : Mascota
    {
        #region Atributos
        private int edad;
        private bool esAlfa;
        #endregion

        #region Propiedades
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public bool EsAlfa
        {
            get { return this.esAlfa; }
            set { this.esAlfa = value; }
        }
        #endregion

        #region Constructor
        public Perro(string nombre, string raza) : this(nombre, raza, 2, false)
        { 

        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre ,raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        #region Metodo
        protected override string Ficha()
        {
            string retorno = "";

            if (esAlfa == true)
            {
                retorno += base.DatosCompletos() + "- Alfa de la Manada " + " - Edad :" + this.Edad.ToString();
            }
            else
            {
                retorno += base.DatosCompletos() + "- Edad " + this.edad.ToString();
            }

            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha(); 
        }

        public override bool Equals(object obj)
        {
            return (this == (Perro)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Perro j1, Perro j2)
        {
            bool retorno = false;

            if(!object.Equals(j1,null) && !object.Equals(j2,null))
            {
                if(j1.Nombre == j2.Nombre && j1.Raza == j2.Raza && j1.Edad == j2.Edad)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }
        #endregion
    }
}
