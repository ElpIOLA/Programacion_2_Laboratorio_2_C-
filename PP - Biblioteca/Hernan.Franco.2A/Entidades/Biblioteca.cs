using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        #region Atributos
        private int _capacidad; //Capacidad maxima de la biblioteca.
        private List<Libro> _libros; 
        #endregion

        #region Constructor
        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }
        #endregion

        #region Propiedades
        public double PrecioDeManuales
        {
            get { return this.ObtenerPrecio(ELibro.Manual); }
        }

        public double PrecioDeNovelas
        {
            get { return this.ObtenerPrecio(ELibro.Novela); }
        }

        public double PrecioTotal
        {
            get { return this.ObtenerPrecio(ELibro.Ambos); }
        }
        #endregion

        #region Metodo
        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double precioTotal = 0;
            double precioManual = 0;
            double precioNovela = 0;

            foreach (Libro item in this._libros)
            {
                if (item is Manual)
                {
                    precioManual += (Manual)item;
                }
                else if (item is Novela)
                {
                    precioNovela += (Novela)item;
                }
            }

            switch (tipoLibro)
            {
                case ELibro.Manual:

                    precioTotal = precioManual;
                    break;
             
                case ELibro.Novela:

                    precioTotal = precioNovela;
                    break;

                case ELibro.Ambos:
                    precioTotal = precioNovela + precioManual;
                    break;
            }

            return precioTotal;
        }

        public static string Mostrar(Biblioteca e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad de la biblioteca: {0}\n", e._capacidad);
            sb.AppendFormat("Precio total de Manual: ${0:0.00}\n", e.PrecioDeManuales);
            sb.AppendFormat("Precio total de Novela: ${0:0.00}\n", e.PrecioDeNovelas);
            sb.AppendFormat("Precio total de Ambos: ${0:0.00}\n", e.PrecioTotal);
            foreach (Libro item in e._libros)
            {
                sb.AppendLine((string)item);

                if (item is Manual)
                {
                    sb.AppendLine(((Manual)item).Mostrar());
                }
                else if (item is Novela)
                {
                    sb.AppendLine(((Novela)item).Mostrar());
                }
            }
            return sb.ToString();
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Biblioteca e, Libro l)
        {
            bool retorno = false;
            if(!object.Equals(e,null) && !object.Equals(l,null))
            {
                for (int i = 0; i < e._libros.Count; i++)
                {
                    if (l is Novela && e._libros[i] is Novela)
                    {
                        if ((Novela)l == (Novela)e._libros[i])
                        {
                            retorno = true;
                            break;
                        }
                    }
                    else if (l is Manual && e._libros[i] is Manual)
                    {
                        if ((Manual)l == (Manual)e._libros[i])
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Biblioteca e, Libro l)
        {
            return !(e == l);
        }

        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            int capacidad = e._libros.Count;
            if (!object.Equals(e, null) && !object.Equals(l, null))
            {
                if(capacidad < e._capacidad)
                {
                    if(e != l)
                    {
                        e._libros.Add(l);
                    }
                }
                else
                {
                    Console.Write("\nNo hay mas espacio en la biblioteca.");
                }
            }
            return e;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca b = new Biblioteca(capacidad);
            return b;
        }
        #endregion
    }
}
