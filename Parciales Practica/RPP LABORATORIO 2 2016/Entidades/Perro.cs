using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{ 
    public class Perro : Animal
    {
        public enum Razas { Galgo, OvejeroAleman }

        #region Atributos
        private static int _patas;
        private Razas _razas;
        #endregion

        #region Constructor
        static Perro()
        {
            _patas = 4;
        }

        public Perro(int velocidadMaxima) : base(_patas, velocidadMaxima){}

        public Perro(Razas raza, int velocidadMaxima) : this(velocidadMaxima)
        {
            this._razas = raza;
        }
        #endregion

        #region Metodos
        public static bool operator  ==(Perro p1, Perro p2)
        {
            bool retorno = false;
            if(p1._razas == p2._razas && p1.VelocidadMaxima == p2.VelocidadMaxima)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public string MostrarPerro()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Perro");
            sb.AppendFormat("Raza : {0}\n", this._razas);

            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();

        }
        #endregion
    }
}
