﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores._2017
{
    class Capitulo
    {
        #region Atributos
        private int _numero;
        private string _titulo;
        private static int ultimoCapitulo;
        #endregion

        #region Propiedades
        public int Numero
        {
            get { return this._numero; }
            //set { this._numero = value; }
        }

        public string Titulo
        {
            get { return this._titulo; }
            //set { this._titulo = value; }
        }
        #endregion

        #region Constructores
        static Capitulo()
        {
            ultimoCapitulo = 1;
        }

        private Capitulo(int numero, string titulo) 
        {
            ultimoCapitulo++;
            this._numero = numero;
            this._titulo = titulo;
        }
        #endregion

        #region Sobrecarga operadores
        public static implicit operator Capitulo(string titulo)
        {

            return new Capitulo(ultimoCapitulo, titulo);
        }
        #endregion
    }
}
