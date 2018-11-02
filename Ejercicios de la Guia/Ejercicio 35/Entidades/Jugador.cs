using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region Atributos
        private int _partidosJugados;
        private int _totalGoles;
        #endregion

        #region Propiedades
        public int PartidosJugados { get { return this._partidosJugados; } }
        public float PromedioGoles
        {
            get
            {
                float promedioGoles = 0;
                if (PartidosJugados > 0 && TotalGoles > 0)
                {
                    promedioGoles = (float)TotalGoles / PartidosJugados;
                }
                return promedioGoles;
            }
        }
        public int TotalGoles { get { return this._totalGoles; } }
        #endregion

        #region Constructor
        public Jugador(string nombre,int totalGoles, int totalPartidos) : base(nombre)
        {
            this._totalGoles = totalGoles;
            this._partidosJugados = totalPartidos;
        }
        #endregion

        #region Metodos
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.MostrarDatos());
            sb.AppendFormat("\nTotal Partidos: {0}", this._partidosJugados);
            sb.AppendFormat("\nTotal Goles: {0}", this._totalGoles);
            sb.AppendFormat("\nPromedio goles: {0:0.00}", PromedioGoles);
            return sb.ToString();
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if(j1.Dni == j2.Dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
