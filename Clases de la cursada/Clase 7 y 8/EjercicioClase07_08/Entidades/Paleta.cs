using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Paleta
    {
        #region Atributos
        private Tempera[] _colores;
        private int _cantMaximaElementos; // Cantidad maxima del array.
        #endregion

        #region Metodos

        private string Mostrar()
        {
            string retorno = "";
            retorno += "Cantidad de elementos: " + this._cantMaximaElementos +"\r\n";
            foreach (Tempera item in this._colores)
            {
                if (!(Object.Equals(item, null)))
                {
                    retorno += item + "\r\n";
                }
            }
            return retorno;
        }

        public static explicit operator string(Paleta P)
        {
            if (!object.Equals(P, null))
            {
                return P.Mostrar();
            }
            return "NULL";
        }

        public static implicit operator Paleta(int N)
        {
            return new Paleta(N);
        }

        public static bool operator ==(Paleta P, Tempera T)
        {
            bool retorno = false;
            for (int i = 0; i < P._colores.GetLength(0); i++)
            {
                if (P._colores.GetValue(i) != null) //Comprobamos que los elementos del array no sean NULL.
                {
                    if (P._colores[i] == T)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta P, Tempera T)
        {
            bool retorno = false;
            for (int i = 0; i < P._colores.GetLength(0); i++)
            {
                if (P._colores.GetValue(i) != null) //Comprobamos que los elementos del array no sean NULL.
                {
                    if (P._colores[i] != T)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static Paleta operator +(Paleta P, Tempera T)
        {
            int index;
            if (P == T)
            {
                index = P.ObtenerIndice(T);
                P._colores[index] += T;
            }
            else
            {
                index = P.ObtenerIndice();
                if (index > -1)
                    P._colores[index] = T;
            }
            return P;
        }

        private int ObtenerIndice()
        {
            int index = -1;
            int contador = 0;

            foreach (Tempera item in this._colores)
            {
                if (this._colores.GetValue(contador) == null)
                {
                    index = contador;
                    break;
                }
                contador++;
            }
            return index;
        }

        private int ObtenerIndice(Tempera T)
        {
            int index = -1;
            int contador = 0;

            foreach (Tempera item in this._colores)
            {
                if (this._colores.GetValue(contador) != null)
                {
                    if (T == item)
                    {
                        index = contador;
                        break;
                    }
                }
                contador++;
            }
            return index;
        }

        public static Paleta operator -(Paleta P, Tempera T)
        {
            int index;
            sbyte size_1;
            sbyte size_2;
            if (P == T)
            {
                index = P.ObtenerIndice(T);
                size_1 = (sbyte)P._colores[index];
                size_2 = (sbyte)T;
                if (size_1 - size_2 <= 0)
                {
                    P._colores[index] = null;
                }
                else
                {
                    P._colores[index] += (sbyte)(size_2 * (-1));
                }
            }
            return P;
        }
        #endregion

        #region Constructor
        private Paleta() : this(5)
        {

        }

        private Paleta(int C)
        {
            this._cantMaximaElementos = C;
            this._colores = new Tempera[this._cantMaximaElementos];
        }
        #endregion

        #region Indexador

        public Tempera this [int indice]
        {
            get
            {
                if (indice >= this._cantMaximaElementos || indice < 0)
                    return null;
                else
                    return this._colores[indice];
            }
            set
            {
                if(indice >= 0 && indice < this._cantMaximaElementos)
                {
                    this._colores[indice] = value;
                } 
                else if(indice == this._colores.GetLength(0))
                {
                    this[indice] = value;
                }
                else
                {
                    Console.WriteLine("No se puede asignar a este elemento");
                    Console.ReadLine();
                }
            }
        }
        #endregion
    }
}
