using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Estante
    {
        #region Atributos
        private int ubicacionEstante;
        private Producto[] productos;
        #endregion

        #region Constructores
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion): this(capacidad)
        {
            ubicacionEstante = ubicacion;
        }
        #endregion

        #region Metodos
        public string GetProducto()
        {
            string retorno = "";
            foreach(string product in productos)
            {
                if(product != null)
                    retorno += " " + product;
            }
            return retorno;
        }

        public static string MostrarEstante(Estante e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            return "\nUbicacion del estante: " + e.ubicacionEstante + "\nProductos: " + e.GetProducto();
        }
        #endregion

        #region Sobrecargas

        public static bool operator ==(Estante e, Producto p)
        {
            int cantidad = e.productos.Length;
            bool retorno = false;
            if(!object.Equals(e,null) && !object.Equals(p, null))
            {
                for(int i = 0; i < cantidad; i++)
                {
                    if(e.productos[i] == p)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            int cantidad = e.productos.Length;
            bool retorno = false;
            if (!object.Equals(e, null) && !object.Equals(p, null))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (e.productos[i] != p)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator +(Estante e, Producto p)
        {
            int cantidad = e.productos.Length;
            int index = 0;
            bool noExiste = false,
                hayEspacio = false,
                retorno = false;
            if (!object.Equals(e, null) && !object.Equals(p, null))
            {
                //Verificamos que el array tenga espacio libre.
                for(int i = 0; i < cantidad; i++)
                {
                    if(e.productos.GetValue(i) == null)
                    {
                        index = i;
                        hayEspacio = true;
                        break;
                    }
                }

                //Verificamos que el producto no exista en el array.
                for(int j = 0; j < cantidad; j++)
                {
                    if(!e.productos.Contains(p))
                    {
                        noExiste = true;
                    }
                }

                if (hayEspacio)
                {
                    if (noExiste)
                    {
                        e.productos.SetValue(p, index);
                        retorno = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("\n\t\tYa existe este producto en el estante.\n");
                    }
                }     
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\n\t\tNo hay mas espacio en el estante.\n");
                }
                    
            }
            return retorno;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            int cantidad = e.productos.Length;
            int index = 0;
            if (!object.Equals(e, null) && !object.Equals(p, null))
            {
                for(int i = 0; i < cantidad; i++)
                {
                    if(e.productos[i] == p)
                    {
                        index = i;
                        break;
                    }
                }
                e.productos[index] = null;
            }
            return e;
        }
        #endregion
    }
}
