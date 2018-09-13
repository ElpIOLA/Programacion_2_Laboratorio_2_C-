using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Calculadora
    {
        #region Atributos
        private double acumulador;
        #endregion

        #region Constructor
        public Calculadora()
        {
            this.acumulador = 0;
        }
        #endregion

        #region Metodos
        public void Acumulador(string bin)
        {
            double numero = Conversor.BinarioDecimal(bin);
            this.acumulador += numero;
        }

        public string getResultadoBinario()
        {
            string bin = Conversor.DecimalBinario(this.acumulador);
            return bin;
        }

        public double getResultadoEntero()
        {
            return this.acumulador;
        }
        #endregion
    }
}
