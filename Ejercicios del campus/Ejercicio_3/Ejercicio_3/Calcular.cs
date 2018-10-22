using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Calcular
    {
        #region Atributos
        private int acumulador;
        #endregion

        #region Constructor
        public Calcular()
        {
            acumulador = 0;
        }
        #endregion

        #region Metodos
        public void acumular(string numeroBinario)
        {
            acumulador += Conversor.BinarioEntero(numeroBinario);
        }

        public string getResultadoBinario()
        {
            return Conversor.EnteroBinario(acumulador);
        }

        public int getResultadoEntero()
        {
            return acumulador;
        }
        #endregion
    }
}
