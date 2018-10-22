using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class MiClase2
    {
        private int _numero;
        private char _letra;

        public MiClase2(int numero, char letra)
        {
            try
            {
                this._numero = numero;
                this._letra = letra;
                new MiClase(this._numero, this._letra);
            }
            catch (Exception e)
            {
                throw new UnaException(e.Message + "\nError en constructor clase 2.", e);
            }
        }
    }
}
