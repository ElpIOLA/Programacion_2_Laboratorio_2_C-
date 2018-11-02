using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<Auto> _lista;
        #endregion

        #region Constructor
        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }
        #endregion

        #region SobreCargas
        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            int capacidad = d._lista.Count;
            bool hayEspacio = false,
                autoAgregado = false;
            //existeAuto = false;

            //foreach(Auto item in d._lista)
            //{
            //    if(item == a)
            //    {
            //        existeAuto = true;
            //    }
            //}

            //if(!existeAuto)
            //{
            if (capacidad < d._capacidadMaxima)
            {
                hayEspacio = true;
            }
            else
                Console.WriteLine("\nNo hay mas espacio!\n");

            if (hayEspacio)
            {
                d._lista.Add(a);
                autoAgregado = true;
            }
            //}

            return autoAgregado;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool borrado = false;
            int indice = d.GetIndice(a);

            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                borrado = true;
                Console.WriteLine("\nAuto borrado");
            }

            return borrado;
        }
        #endregion

        #region Metodos
        public bool Agregar(Auto a)
        {
            bool retorno = false;

            if (this + a)
            {
                retorno = true;
            }

            return retorno;

        }

        public bool Remover(Auto a)
        {
            bool retorno = false;

            retorno = this - a;

            return retorno;
        }

        private int GetIndice(Auto a)
        {
            int index = -1;
            bool existe = false;

            foreach (Auto item in this._lista)
            {
                index++;
                if (item == a)
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
            retorno += "\nCantidad maxima de autor: " + this._capacidadMaxima;
            retorno += "\nCantidad de autos en el Deposito: " + this._lista.Count;
            retorno += "\nLista de autos:";
            foreach (Auto item in this._lista)
            {
                retorno += "\n" + item.ToString();

            }
            return retorno;
        }
        #endregion
    }
}
