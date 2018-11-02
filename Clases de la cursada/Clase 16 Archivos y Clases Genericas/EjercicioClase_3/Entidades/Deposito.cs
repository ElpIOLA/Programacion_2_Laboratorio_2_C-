using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito <T>
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<T> _lista;
        #endregion

        #region Constructor
        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }
        #endregion

        #region SobreCargas
        public static bool operator +(Deposito<T> d, T a)
        {
            bool hayEspacio = false,
                existe = false;
            int capacidad = d._lista.Count;

            foreach(T item in d._lista)
            {
                if(item.Equals(a))
                {
                    existe = true;
                    break;
                }
            }

            if(!existe)
                if (capacidad < d._capacidadMaxima)
                    hayEspacio = true;

            if (hayEspacio)
                d._lista.Add(a);

            return hayEspacio;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            bool borrado = false;
            int indice = d.GetIndice(a);

            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                borrado = true;
            }

            return borrado;
        }
        #endregion

        #region Metodo
        public bool Agregar(T a)
        {
            bool retorno = false;

            if (this + a)
            {
                retorno = true;
            }

            return retorno;

        }

        public bool Remover(T a)
        {
            bool retorno = false;

            if (this - a)
            {
                retorno = true;
            }

            return retorno;
        }

        private int GetIndice(T c)
        {
            int index = -1;
            bool existe = false;

            foreach (T item in this._lista)
            {
                index++;
                if (Equals(item,c))
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
                index = -1;

            return index;
        }
        #endregion

        #region Polimorfismo
        public override string ToString()
        {
            string retorno = "";
            retorno += "\nCantidad maxima del Deposito: " + this._capacidadMaxima;
            retorno += "\nCantidad de objetos T en el Deposito: " + this._lista.Count;
            retorno += "\nLista de objetos T:";
            foreach (T item in this._lista)
            {
                retorno += "\n" + item.ToString();

            }
            return retorno;
        }
        #endregion
    }
}
