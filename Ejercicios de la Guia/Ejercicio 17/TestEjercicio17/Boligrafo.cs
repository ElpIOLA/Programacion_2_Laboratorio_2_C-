using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEjercicio17
{
    class Boligrafo
    {
        #region Atributos
        private short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;
        #endregion

        #region Constructor
        public Boligrafo(ConsoleColor color, short tinta)
        {
            _color = color;
            SetTinta(tinta);
        }
        #endregion

        #region Metodos
        public ConsoleColor GetColor()
        {
            return _color;
        }

        public short GetTinta()
        {
            return _tinta;
        }

        private void SetTinta(short tinta)
        {
            if(tinta <= cantidadTintaMaxima)
            {
                _tinta = tinta;
            }
        }

        public void Recargar()
        {
            _tinta = cantidadTintaMaxima;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";
            bool retorno = false;
            int nivelTinta = GetTinta() - gasto;

            if (nivelTinta > 0)
            {
                Console.WriteLine("\nSu nivel de tinta restante es: {0}", nivelTinta);
                for(int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
                Console.WriteLine("\nGasto: {0} - {1}\nNiveles de tinta.", dibujo,gasto);
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
