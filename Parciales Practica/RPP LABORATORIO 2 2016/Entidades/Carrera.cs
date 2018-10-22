using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera
    {
        #region Atributos
        private List<Animal> _animales;
        private int _corredorMax;
        #endregion

        #region Constructor
        private Carrera()
        {
            this._animales = new List<Animal>();
        }

        public Carrera(int corredorMax) : this()
        {
            this._corredorMax = corredorMax;
        }
        #endregion

        #region Metodos

        public static string MostrarCarrera(Carrera c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CARRERA");

            sb.AppendFormat("Maximo de corredores: {0}\n", c._corredorMax);

            foreach (Animal item in c._animales)
            {
                sb.AppendLine(item.MostrarDatos());

            }

            return sb.ToString();
        }

        public static bool operator ==(Carrera c, Animal a)
        {
            bool retorno = false;
            foreach(Animal item in c._animales)
            {
                if(item.GetType() == a.GetType() && item == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Carrera c, Animal a)
        {
            return !(c == a);
        }

        public static Carrera operator +(Carrera c, Animal a)
        {
            if(c != a)
            {
                if(c._animales.Count + 1 <= c._corredorMax)
                {
                    c._animales.Add(a);
                }
            }
            return c;
        }
        #endregion
    }
}
