using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class PaletaCollection
    {
        #region Atributos
        private List<Tempera> colores;
        private int _cantMaximaElementos; // Cantidad maxima del array.
        #endregion

        #region Metodos

        private string Mostrar()
        {
            string retorno = "";
            retorno += "Cantidad de elementos: " + this._cantMaximaElementos +"\r\n";
            foreach (Tempera item in this.colores)
            {
                if (!(Object.Equals(item, null)))
                {
                    retorno += item + "\r\n";
                }
            }
            return retorno;
        }

        public static explicit operator string(PaletaCollection P)
        {
            if (!object.Equals(P, null))
            {
                return P.Mostrar();
            }
            return "NULL";
        }

        public static implicit operator PaletaCollection(int N)
        {
            return new PaletaCollection(N);
        }

        public static bool operator ==(PaletaCollection P, Tempera T)
        {
            int contador = 0;
            bool retorno = false;
            foreach (Tempera item in P.colores)
            {
                if (item != null)
                {
                    if (T == item)
                    {
                        retorno = true;
                        break;
                    }
                }
                contador++;
            }
            return retorno;
        }

        public static bool operator !=(PaletaCollection P, Tempera T)
        {
            int contador = 0;
            bool retorno = false;
            foreach (Tempera item in P.colores)
            {
                if (item != null)
                {
                    if (T != item)
                    {
                        retorno = true;
                        break;
                    }
                }
                contador++;
            }
            return retorno;
        }
    

        public static int operator ==(Tempera T, PaletaCollection P)
        {
            int contador = 0, index = -1;
            foreach(Tempera item in P.colores)
            {
                if (item != null)
                {
                    if (T == item)
                    {
                        index = contador;
                    }
                }
                contador++;
            }
            return index;
        }

        public static int operator !=(Tempera T, PaletaCollection P)
        {
            int contador = 0, index = -1;
            foreach (Tempera item in P.colores)
            {
                if (item != null)
                {
                    if (T != item)
                    {
                        index = contador;
                    }
                }
                contador++;
            }
            return index;
        }



        public static PaletaCollection operator +(PaletaCollection P, Tempera T)
        {
            int index;
            if (P == T)
            {
                index = (T == P);
                if (index != -1)
                    P.colores[index] += T;
            }
            else
            {
                if (P._cantMaximaElementos > P.colores.Count)
                    P.colores.Add(T);
            }
            return P;
        }  

        public static PaletaCollection operator -(PaletaCollection P, Tempera T)
        {
            int index;
            sbyte size_1;
            sbyte size_2;
            if (P == T)
            {
                index = (T == P);
                size_1 = (sbyte)P.colores[index];
                size_2 = (sbyte)T;

                if (size_1 - size_2 <= 0)
                {
                    P.colores.Remove(P.colores[index]);
                }
                else
                {
                    P.colores[index] += (sbyte)(size_2 * (-1));
                }
            }
            return P;
        }
        #endregion

        #region Constructor
        private PaletaCollection() : this(5)
        {

        }

        private PaletaCollection(int C)
        {
            this._cantMaximaElementos = C;
            List<Tempera> colores = new List<Tempera>(_cantMaximaElementos);
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
                    return this.colores[indice];
            }
            set
            {
                int cantidad = this.colores.Count;

                if(indice >= 0 && indice < this._cantMaximaElementos)
                {
                    this.colores[indice] = value;
                } 
                else if(indice == cantidad)
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
