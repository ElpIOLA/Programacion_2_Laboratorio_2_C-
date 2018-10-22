using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Cajon
    {
        #region Atributos
        private List<Fruta> lista;
        private int _volumen;
        #endregion

        #region Constructor
        private Cajon()
        {
            this.lista = new List<Fruta>();
        }
        public Cajon(int limite) : this()
        {
            this._volumen = limite;
        }
        #endregion

        #region Metodos
        public int CalcularEspacioDisponible()
        {
            int acumulador = 0;

            foreach(Fruta fruta in lista)
            {
                acumulador += fruta._volumen;
            }

            return this._volumen - acumulador;
            
        }

        public string MostrarContenido()
        {
            Fruta frutita = new Fruta();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nEl volumen total ocupado: {0}. El volumen total {1}", CalcularEspacioDisponible(), this._volumen);
            sb.AppendFormat("\nDatos de la fruta: \n\t\t Peso: {0} \t Espacio ocupado: {1}", frutita._peso, frutita._volumen);
            return sb.ToString();
        }

        public void AgregarFruta(Fruta f)
        {
            if (this.CalcularEspacioDisponible() > f._volumen)
            {
                this.lista.Add(f);
            }
        }

        public void QuitarFruta()
        {
            if (this.lista.Count > 0)
            {
                Random r = new Random();
                this.lista.RemoveAt(r.Next(0, this.lista.Count));
            }
        }
        #endregion
    }
}
