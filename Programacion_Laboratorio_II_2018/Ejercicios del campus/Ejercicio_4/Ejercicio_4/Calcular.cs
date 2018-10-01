using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
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

        public Calcular(int numero)
        {
            acumulador = numero;
        }

        public Calcular(string numero) : this(Conversor.BinarioEntero(numero))
        {

        }
        #endregion

        #region Metodos
        public void acumular(string numeroBinario)
        {
            acumulador += Conversor.BinarioEntero(numeroBinario);
        }

        public void acumular(int numeroEntero)
        {
            acumulador += numeroEntero;
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
