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
                            retorno += ((Local)item).CostoLlamada;
                        }
                        break;

                    case TipoLlamada.Provincial:

                        if (item is Provincial)
                        {
                            retorno += ((Provincial)item).CostoLlamada;
                        }
                        break;

                    default:
                        if (item is Local)
                        {
                            retorno += ((Local)item).CostoLlamada;
                        }

                        if (item is Provincial)
                        {
                            retorno += ((Provincial)item).CostoLlamada;
                        }
                        break;
                }
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nRazon social: {0}", this._razonSocial);
            sb.AppendFormat("\nTotal Locales: ${0:0.00}", this.GananciasPorLocal);
            sb.AppendFormat("\nTotal Provinciales: ${0:0.00}", this.GananciasPorProvincial);
            sb.AppendFormat("\nTotal Totales: ${0:0.00}", this.GananciasPorTotal);
            sb.AppendFormat("\n\t\tLista de llamadas\n");
            foreach(Llamada item in this._listaDeLlamadas)
            {
                sb.AppendFormat("\n{0}",item.Mostrar());
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}
