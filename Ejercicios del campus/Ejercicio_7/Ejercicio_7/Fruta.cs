using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Fruta
    {
        #region Atributos
        public float _peso;
        public int _volumen;
        #endregion

        #region Constructor
        public Fruta()
        {
            Random aleatorio = new Random();
            this._peso = aleatorio.Next(1, 5);
            this._volumen = aleatorio.Next(1, 10);
        }
        #endregion
    }
}
