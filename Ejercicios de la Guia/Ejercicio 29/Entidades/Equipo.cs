using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Atributos
        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;
        #endregion

        #region Constructor
        private Equipo()
        {
            _jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            _cantidadDeJugadores = cantidad;
            _nombre = nombre;
        }
        #endregion

        #region SobreCarga
        public static bool operator +(Equipo e, Jugador j)
        {
            bool existe = false,
                agregado = false;
            int cantidad = e._jugadores.Count();

            if (cantidad <= e._cantidadDeJugadores)
            {
                foreach (Jugador item in e._jugadores)
                {
                    if (item == j)
                    {
                        existe = true;
                        break;
                    }
                }

                if (!existe)
                {
                    e._jugadores.Add(j);
                    agregado = true;
                }
            }

            return agregado;
        }
        #endregion
    }
}
