using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get { return CalcularGanancias(TipoLlamada.Local); }
        }
        public float GananciasPorProvincial
        {
            get { return CalcularGanancias(TipoLlamada.Provincial); }
        }
        public float GananciasPorTotal
        {
            get { return CalcularGanancias(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
        }
        #endregion

        #region Constructor
        private Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        private float CalcularGanancias(TipoLlamada tipo)
        {
            float retorno = 0;

            foreach (Llamada item in this._listaDeLlamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (item is Local)
                        {
                            retorno += ((Local)item).CostoLlamado;
                        }
                        break;

                    case TipoLlamada.Provincial:

                        if (item is Provincial)
                        {
                            retorno += ((Provincial)item).CostoLlamado;
                        }
                        break;

                    default:
                        if (item is Local)
                        {
                            retorno += ((Local)item).CostoLlamado;
                        }

                        if (item is Provincial)
                        {
                            retorno += ((Provincial)item).CostoLlamado;
                        }
                        break;
                }
            }
            return retorno;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nRazon social: {0}", this._razonSocial);
            sb.AppendFormat("\nTotal Locales: ${0:0.00}", this.GananciasPorLocal);
            sb.AppendFormat("\nTotal Provinciales: ${0:0.00}", this.GananciasPorProvincial);
            sb.AppendFormat("\nTotal Totales: ${0:0.00}", this.GananciasPorTotal);
            sb.AppendFormat("\n\n\t\tLista de llamadas");
            foreach(Llamada item in this._listaDeLlamadas)
            {
                sb.AppendFormat("\n{0}",item.ToString());
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
        }
        #endregion

        #region SobreCarga
        public static bool operator ==(Centralita c, Llamada l)
        {
            bool existe = false;
            foreach(Llamada item in c._listaDeLlamadas)
            {
                if(item == l)
                {
                    existe = true;
                }
            }
            return existe;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if(c != l)
            {
                c.AgregarLlamada(l);
            }
            return c;
        }
        #endregion

        #region Polimorfismo
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
