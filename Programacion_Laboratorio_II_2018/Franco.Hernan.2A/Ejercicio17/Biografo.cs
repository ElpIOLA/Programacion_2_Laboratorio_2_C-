using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Biografo
    {
        #region atributos
        public static short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        #endregion

        #region metodos

        public Biografo(ConsoleColor c, short t)
        {
            this.color = c;
            this.SetTinta(t);
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta > 0 && tinta <= 100)
            {
                this.tinta = tinta;
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(int gasto,out string dibujo)
        {
            bool retorno = false;
            dibujo = "";
            int resultado = this.GetTinta() - gasto;
            if(resultado > 0)
            {
                for(int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
                Console.BackgroundColor = this.GetColor();
                Console.Write("\nNivel gastado de tinta: {0}\n", dibujo);
                Console.Write("\nCantidad de tinta que sobro: {0}\n", resultado);
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
