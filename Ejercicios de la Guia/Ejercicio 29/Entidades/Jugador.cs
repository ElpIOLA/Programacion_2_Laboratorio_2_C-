using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        #region Atributos
        private long _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioGoles;
        private int _totalGoles;
        #endregion

        #region Constructor
        private Jugador()
        {
            this._promedioGoles = 0;
            this._partidosJugados = 0;
            this._totalGoles = 0;
        }

        public Jugador(string nombre, long dni) : this()
        {
            this._nombre = nombre;
            this._dni = dni;
        }

        public Jugador(string nombre, long dni, int totalGoles, int totalPartidos) : this(nombre,dni)
        {
            this._totalGoles = totalGoles;
            this._partidosJugados = totalPartidos;
        }
        #endregion

        #region Metodos
        public float GetPromedioGoles()
        {
            return this._promedioGoles = (float)this._totalGoles / this._partidosJugados; 
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n\nNombre: {0}", this._nombre);
            sb.AppendFormat("\nDNI: {0}", this._dni);
            sb.AppendFormat("\nTotal Partidos: {0}", this._partidosJugados);
            sb.AppendFormat("\nTotal Goles: {0}", this._totalGoles);
            sb.AppendFormat("\nPromedio goles: {0:0.00}", GetPromedioGoles());
            return sb.ToString();
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if(j1._dni == j2._dni)
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
