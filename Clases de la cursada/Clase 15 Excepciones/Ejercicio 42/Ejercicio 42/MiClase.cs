using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class MiClase
    {
        private int _numero;
        private char _letra;

        public MiClase(int numero, char letra)
        {
            try
            {
                this._numero = numero;
                this._letra = letra;
                Program.lanzarException();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
