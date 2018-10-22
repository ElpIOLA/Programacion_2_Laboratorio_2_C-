using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan.Franco._2A
{
    public enum TipoManada
    {
        Única, Mixta,
    }
    class Grupo
    {
     
        #region Atributos
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;
        #endregion

        #region Propiedades
        public TipoManada Tipo
        {
            set { tipo = value; }
        }
        #endregion

        #region Constructores
        static Grupo()
        {
            tipo = TipoManada.Única;
        } 

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string name) : this()
        {
            this.nombre = name;
        }

        public Grupo(string name, TipoManada tipoManada) : this(name)
        {
            tipo = tipoManada;
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Grupo e, Mascota j)
        {
            int cantidad = e.manada.Count;
            bool retorno = false;

            for(int i = 0; i < cantidad; i++)
            {
                if(e.manada[i] == j)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            if (!object.Equals(e, null) && !object.Equals(j, null))
            {
                if(e != j)
                {
                    e.manada.Add(j);
                }
            }
            return e;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            if (e == j)
            {
                e.manada.Remove(j);
            }
            return e;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("***{0} - {1}***\n", e.nombre, Grupo.tipo);
            sb.AppendLine("Integrantes");

            foreach(Mascota item in e.manada)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion
    }
}
