using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoCompetencia
    {
        F1,
        MotoCross,
    }

    public class Competencia
    {
        #region Atributos
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private TipoCompetencia _tipo;
        private List<VehiculoDeCarrera> _competidores;
        #endregion

        #region Propiedades
        public short CantidadCompetidores
        {
            get { return this._cantidadCompetidores; }
            set { this._cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this._cantidadVueltas; }
            set { this._cantidadVueltas = value; }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                for(int j = 0; j < this._competidores.Count; j++)
                {
                    if(j == i)
                    {
                        return this._competidores[i];
                        break;
                    }
                }
                return null;
            }
        }

        public TipoCompetencia Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }
        #endregion

        #region Constructor
        private Competencia()
        {
            this._competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cVueltas, short cCompetidores, TipoCompetencia tipo) : this()
        {
            this._cantidadVueltas = cVueltas;
            this._cantidadCompetidores = cCompetidores;
            this._tipo = tipo;
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
                Console.ForegroundColor = ConsoleColor.Red;
                sb.AppendFormat("\n{0}", item.MostrarDato());
            }
            return sb.ToString();
        }
        #endregion

        #region SobreCarga
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool existe = false;
            foreach(VehiculoDeCarrera item in c._competidores)
            {
                if(item == v)
                {
                    existe = true;
                }
            }
            return existe;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool autoAgregado = false;
            bool hayEspacio = false;
            int cantidad = c._competidores.Count;
            
            if(cantidad < c._cantidadCompetidores)
            {
                hayEspacio = true;
            }
            else
            {
                Console.Write("\nNo hay mas espacio\n");
            }

            if (hayEspacio)
            {
                if (c != v)
                {
                    switch (c.Tipo)
                    {
                        case TipoCompetencia.F1:
                            {
                                if (c.Tipo is TipoCompetencia.F1)
                                {
                                    c._competidores.Add(v);
                                    return autoAgregado = true;
                                }
                            }
                            break;
                        case TipoCompetencia.MotoCross:
                            {
                                if (c.Tipo is TipoCompetencia.MotoCross)
                                {
                                    c._competidores.Add(v);
                                    return autoAgregado = true;
                                }
                            }
                            break;
                    }
                }
                else
                {
                    Console.Write("\nEl vehiculo ya se encuentra en la carrera.\n");
                }
            }
            return autoAgregado;
        }
        #endregion
    }
}
