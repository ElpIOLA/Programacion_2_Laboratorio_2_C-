using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        #region Atributos
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        #endregion

        #region Metodos
        public void CalcularFinal()
        {
            Random r = new Random();
            this._notaFinal = r.Next(4, 10);
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            _nota1 = notaUno;
            _nota2 = notaDos;
            if (_nota1 >= 4 && _nota2 >= 4)
                CalcularFinal();
            else
                this._notaFinal = -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0}", this.nombre);
            sb.AppendFormat("\nApellido: {0}", this.apellido);
            sb.AppendFormat("\nLegajo: {0}", this.legajo);
            sb.AppendFormat("\nPrimer nota: {0}", this._nota1);
            sb.AppendFormat("\nSegunda nota: {0}", this._nota2);
            sb.AppendFormat("\nFinal: {0}\n\n", this._notaFinal);
            return sb.ToString();
        }
        #endregion
    }
}
