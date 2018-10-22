using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        #region Atributos
        protected int _cantidadPatas;
        protected static Random _distanciaRecorrida;
        protected  int _velocidadMaxima;
        #endregion

        #region Constructor
        static Animal()
        {
            _distanciaRecorrida = new Random();
        }

        public Animal(int cantidadPatas, int velocidadMaxima)
        {
            this._cantidadPatas = cantidadPatas;
            this._velocidadMaxima = velocidadMaxima;
        }
        #endregion

        #region Propiedades
        public int CantidadPatas
        {
            get { return this._cantidadPatas; }
            set
            {
                if(value <= 4)
                {
                    this._cantidadPatas = value;
                }
                else
                {
                    this._cantidadPatas = 4;
                }
            }
        }

        public int VelocidadMaxima
        {
            get { return this._velocidadMaxima; }
            set
            {
                if(value <= 60)
                {
                    this._velocidadMaxima = value;
                }
                else
                {
                    this._velocidadMaxima = 60;
                }
            }
        }

        private int DistanciaRecorrida
        {
            get
            {
                return Animal._distanciaRecorrida.Next(10, this._velocidadMaxima);
            }
        }
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nCantidad de patas: {0}", this._cantidadPatas);
            sb.AppendFormat("\nDistancia Recorrida: {0}", this.DistanciaRecorrida);
            sb.AppendFormat("\nVelocidad maxima: {0}\n", this._velocidadMaxima);
            return sb.ToString();
        }
        #endregion
    }
}
