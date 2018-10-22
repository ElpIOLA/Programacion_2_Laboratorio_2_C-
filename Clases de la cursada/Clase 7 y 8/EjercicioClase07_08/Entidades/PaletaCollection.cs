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
                if (!(object.Equals(item, null)))
                {
                    retorno += item + "\r\n";
                }
            }
            return retorno;
        }

        public static explicit operator string(PaletaCollection P)
        {
            return P.Mostrar();
        }

        public static implicit operator PaletaCollection(int N)
        {
            PaletaCollection retorno = new PaletaCollection(N);
            return retorno;
        }

        public static bool operator ==(PaletaCollection P, Tempera T)
        {
            bool retorno = false;
            if(!object.Equals(T,null))
            {
                foreach (Tempera item in P.colores)
                {
                    if (!object.Equals(item,null))
                    {
                        if (item == T)
                            retorno = true;
                            break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(PaletaCollection P, Tempera T)
        {
            return !(P == T);
        }

        public static int operator ==(Tempera T, PaletaCollection P)
        {
            int contador = 0;
            int indice = -1;
            if(!object.Equals(T,null) && !object.Equals(P,null))
            {
                foreach (Tempera item in P.colores)
                {
                    if (item != null)
                    {
                        if (item == T)
                        {
                            indice = contador;
                        }
                    }
                    contador++;
                }
            }
            return indice;
        }

        public static int operator !=(Tempera T, PaletaCollection P)
        {
            return T == P;
        }
    
        public static PaletaCollection operator +(PaletaCollection P, Tempera T)
        {
            int indice;

            if (!object.Equals(P, null) && !object.Equals(T, null))
            {
                indice = (T == P);
                if (indice != -1)
                {
                    P.colores[indice] += T;

                }
                else
                {
                    if (P.colores.Count < P._cantMaximaElementos)
                    {
                        P.colores.Add(T);
                    }
                }

            }
            return P;
        }  

        public static PaletaCollection operator -(PaletaCollection P, Tempera T)
        {
            int indice;
            sbyte aux;
            sbyte aux2;


            indice = (T == P);
            if (indice != -1)
            {
                aux = (sbyte)P.colores[indice];
                aux2 = (sbyte)T;

                if (aux - aux2 <= 0)
                {
                    P.colores.RemoveAt(indice);
                }
                else
                {
                    P.colores[indice] += ((sbyte)(aux2 * (-1)));
                }
            }
            return P;
        }
        #endregion

        #region Propiedades
        public int cantiadTemperas
        {
            get
            {
                return this.colores.Count;
            }
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

        public Tempera this[int indice]
        {
            get
            {
                if (indice >= this.colores.Count || indice < 0 && indice < this._cantMaximaElementos)
                    return null;
                else
                    return this.colores[indice];
            }
            set
            {
                if (indice >= 0 && indice < this._cantMaximaElementos)
                    this.colores[indice] = value;
                else
                {
                    Console.WriteLine("Valor erroneo");
                }
            }
        }
        #endregion
    }
}
