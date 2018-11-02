using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        #region Atributos
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<AutoF1> _competidores;
        #endregion

        #region Constructor
        private Competencia()
        {
            this._competidores = new List<AutoF1>();
        }

        public Competencia(short cVueltas, short cCompetidores) : this()
        {
            this._cantidadVueltas = cVueltas;
            this._cantidadCompetidores = cCompetidores;
        }
        #endregion

        #region Metodo
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n\t\tCARRERA DE FORMULA 1");
            sb.AppendFormat("\nCantidad de vueltas: {0}", this._cantidadVueltas);
            sb.AppendFormat("\nCantidad de competidores: {0}", this._competidores.Count());
            sb.AppendFormat("\n\n\t\tLISTA DE AUTOS");
            foreach (AutoF1 item in this._competidores)
            {
                Console.ForegroundColor = ConsoleColor.red;
                sb.AppendFormat("\n{0}", item.MostrarDatos());
            }
            return sb.ToString();
        }
        #endregion

        #region SobreCarga
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool existe = false;
            foreach(AutoF1 item in c._competidores)
            {
                if(item == a)
                {
                    existe = true;
                }
            }
            return existe;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool hayEspacio = false,
                autoAgregado = false;
            int cantidad = c._competidores.Count();
            if(cantidad < c._cantidadCompetidores)
            {
                hayEspacio = true;
            }

            if(hayEspacio)
            {
                if(c != a)
                {
                    Random r = new Random();

                    a.EnCompetencia = true;
                    a.VueltasRestantes = c._cantidadVueltas;
                    a.CantidadCombustible = (short)r.Next(15, 100);

                    c._competidores.Add(a);  
                    
                    autoAgregado = true;
                }
                else
                {
                    Console.Write("\nEl auto ya esta en la carrera!\n");
                }
            }

            return autoAgregado;
        }
        #endregion
    }
}
