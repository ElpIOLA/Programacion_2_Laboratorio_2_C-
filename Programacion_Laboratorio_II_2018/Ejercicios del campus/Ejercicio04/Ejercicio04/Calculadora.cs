using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Calculadora
    {
        #region Atributos
        private int acumulador;
        #endregion

        #region Constructor
        public Calculadora()
        {
            this.acumulador = 0;
        }

        public Calculadora(int numero)
        {
            this.acumulador = numero;
        }

        public Calculadora(string numero) : this(Conversor.BinarioDecimal(numero))
        {

        }
        #endregion

        #region Metodos
        public void Acumulador(string bin)
        {
            int numero = Conversor.BinarioDecimal(bin);
            this.acumulador += numero;
        }

        public void Acumulador(int numero)
        {
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
