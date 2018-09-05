using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        #region atributos
        private byte _Nota1;
        private byte _Nota2;
        private float _NotaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        #endregion

        #region metodos
        
        public Alumno(string n, string a, int l)
        {
            this.nombre = n;
            this.apellido = a;
            this.legajo = l;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._Nota1 = notaUno;
            this._Nota2 = notaDos;
            CalcularFinal();
        }

        public void CalcularFinal()
        {
            if (this._Nota1 >= 4 && this._Nota2 >= 4)
            {
                this._NotaFinal = (float)(this._Nota1 + this._Nota2) / 2;
            }
            else
            {
                this._NotaFinal = -1;
            }
        }

        public void Mostrar()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            string mostrar = "";
            mostrar += "\nNombre: ";
            mostrar += this.nombre;
            mostrar += "\nApellido: ";
            mostrar += this.apellido;
            mostrar += "\nLegajo: ";
            mostrar += this.legajo;
            mostrar += "\nPrimer Nota: ";
            mostrar += this._Nota1;
            mostrar += "\nSegunda Nota: ";
            mostrar += this._Nota2;
            mostrar += "\nNota Final: ";
            mostrar += this._NotaFinal;
            mostrar += "\n";
            Console.Write(mostrar);
        }
        #endregion
    }
}
